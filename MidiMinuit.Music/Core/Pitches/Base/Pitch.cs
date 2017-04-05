using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MidiMinuit.Music.Common;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.StepAccidentals;
using MidiMinuit.Music.Core.StepNames;
using MidiMinuit.Music.Core.Steps;

namespace MidiMinuit.Music.Core.Pitches
{
    /// <summary>
    ///     Note Pitch (hauteur).
    ///     Cette classe représente la hauteur d'un son
    ///     http://programmers.stackexchange.com/questions/178817/oo-design-how-to-model-tonal-harmony
    /// </summary>
    public partial class Pitch
        : Step, IComparable<Pitch>
    {
        private static Dictionary<string, int> _pitches
            = StepName
                .CreateAll()
                .ToDictionary(x => x.Name, x => x.MidiPitch);

        public Pitch(string name, int accidentalValue, int octaveNumber)
        {
            Name = name;
            Accidental = accidentalValue;
            MidiPitch = _pitches[Name.Name] + Accidental.Value + ((octaveNumber - 4) * 12);
            Octave = octaveNumber;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="name">The name of the note.</param>
        /// <param name="accidental">The accidental of the note.</param>
        /// <param name="octaveNumber">The octave of the note.</param>
        public Pitch(StepNameAlias name, NoteAccidentalAlias accidental = NoteAccidentalAlias.Flat, int octaveNumber = 4)
        {
            Name = name;
            Accidental = accidental;
            MidiPitch = _pitches[Name.Name] + Accidental.Value + ((octaveNumber - 4) * 12);
            Octave = octaveNumber;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="s">
        ///     The name of the note with its accidental.
        ///     ex: "C#" or "Db" or E...
        /// </param>
        /// <exception cref="ArgumentNullException">note</exception>
        /// <exception cref="ArgumentException">incorrect format</exception>
        public Pitch(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException(nameof(s));
            }

            if (!new Regex("^[A-Ga-g]((bb?|##?)|(♭♭?|♯♯?))?[0-8]?$").IsMatch(s))
            {
                throw new ArgumentException("incorrect format");
            }

            var regexNote = new Regex("^[A-Ga-g]$");
            var regexAlter = new Regex("^[b♭#♯]$");
            var regexOctave = new Regex("^[0-8]$");

            string name = string.Empty;
            string accidental = string.Empty;
            string octaveNumber = string.Empty;

            foreach (char c in s)
            {
                if (name == string.Empty)
                {
                    if (regexNote.IsMatch(c.ToString()))
                    {
                        name += char.ToUpper(c).ToString();
                    }
                }
                else
                {
                    if (regexAlter.IsMatch(c.ToString()))
                    {
                        accidental += c.ToString();
                    }
                    else if (regexOctave.IsMatch(c.ToString()))
                    {
                        octaveNumber += c.ToString();
                    }
                }
            }

            var octaveNumberParsed = Convert.ToInt32(octaveNumber);

            Name = name;
            Accidental = accidental;
            MidiPitch = _pitches[Name.Name] + Accidental.Value + ((octaveNumberParsed - 4) * 12);
            Octave = octaveNumberParsed;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="pitch">The note.</param>
        public Pitch(Pitch pitch)
            : this(pitch.Name, pitch.Accidental, pitch.Octave)
        {
        }

        protected Pitch()
        {
        }

        public int MidiPitch { get; set; }

        public int Octave { get; set; }

        public int PitchAbsolute
        {
            get
            {
                var pitch = Name.Semitones + Accidental.Value;
                if (pitch < 0)
                {
                    pitch += 12;
                }

                return pitch;
            }
        }

        ////public Interval GetInterval()
        ////{
        ////    // http://www.tabs4acoustic.com/forum-guitare/tableau-intervalles-et-gammes-majeure-et-mineures-t9478.html
        ////    // ne serait-ce pas plutôt une chromatic scale
        ////    switch (ToString())
        ////    {
        ////        case "C":
        ////            return new Interval("C", "D♭", "D", "D♯", "E♭", "E", "F", "F♯", "G♭", "G", "G♯", "A♭", "A", "B♭♭",
        ////                "B♭", "B", "C");
        ////        case "C♯":
        ////            return new Interval("C♯", "D", "D♯", "D♯♯", "E", "E♯", "F♯", "F♯♯", "G", "G♯", "G♯♯", "A", "A♯",
        ////                "B♭", "B", "B♯", "C♯");
        ////        case "D♭":
        ////            return new Interval("D♭", "E♭♭", "E♭", "E", "F♭", "F", "G♭", "G", "A♭♭", "A♭", "A", "B♭♭", "B♭",
        ////                "C♭♭", "C♭", "C", "D♭");
        ////        case "D":
        ////            return new Interval("D", "E♭", "E", "E♯", "F", "F♯", "G", "G♯", "A♭", "A", "A♯", "B♭", "B", "C♭",
        ////                "C", "C♯", "D");
        ////        case "D♯":
        ////            return new Interval("D♯", "E", "E♯", "E♯♯", "F♯", "F♯♯", "G♯", "G♯♯", "A", "A♯", "A♯♯", "B", "B♯",
        ////                "C", "C♯", "C♯♯", "D♯");
        ////        case "E♭":
        ////            return new Interval("E♭", "F♭", "F", "F♯", "G♭", "G", "A♭", "A", "B♭♭", "B♭", "B", "C♭", "C", "D♭♭",
        ////                "D♭", "D", "E♭");
        ////        case "E":
        ////            return new Interval("E", "F", "F♯", "F♯♯", "G", "G♯", "A", "A♯", "B♭", "B", "B♯", "C", "C♯", "D♭",
        ////                "D", "D♯", "E");
        ////        case "F":
        ////            return new Interval("F", "G♭", "G", "G♯", "A♭", "A", "B♭", "B", "C♭", "C", "C♯", "D♭", "D", "E♭♭",
        ////                "E♭", "E", "F");
        ////        case "F♯":
        ////            return new Interval("F♯", "G", "G♯", "G♯♯", "A", "A♯", "B", "B♯", "C", "C♯", "C♯♯", "D", "D♯", "E♭",
        ////                "E", "E♯", "F♯");
        ////        case "G♭":
        ////            return new Interval("G♭", "A♭♭", "A♭", "A", "B♭♭", "B♭", "C♭", "C", "D♭♭", "D♭", "D", "E♭♭", "E♭",
        ////                "F♭♭", "F♭", "F", "G♭");
        ////        case "G":
        ////            return new Interval("G", "A♭", "A", "A♯", "B♭", "B", "C", "C♯", "D♭", "D", "D♯", "E♭", "E", "F♭",
        ////                "F", "F♯", "G");
        ////        case "G♯":
        ////            return new Interval("G♯", "A", "A♯", "A♯♯", "B", "B♯", "C♯", "C♯♯", "D", "D♯", "D♯♯", "E", "E♯", "F",
        ////                "F♯", "F♯♯", "G♯");
        ////        case "A♭":
        ////            return new Interval("A♭", "B♭♭", "B♭", "B", "C♭", "C", "D♭", "D", "E♭♭", "E♭", "E", "F♭", "F", "G♭♭",
        ////                "G♭", "G", "A♭");
        ////        case "A":
        ////            return new Interval("A", "B♭", "B", "B♯", "C", "C♯", "D", "D♯", "E♭", "E", "E♯", "F", "F♯", "G♭",
        ////                "G", "G♯", "A");
        ////        case "A♯":
        ////            return new Interval("A♯", "B", "B♯", "B♯♯", "C♯", "C♯♯", "D♯", "D♯♯", "E", "E♯", "E♯♯", "F♯", "F♯♯",
        ////                "G", "G♯", "G♯♯", "A♯");
        ////        case "B♭":
        ////            return new Interval("B♭", "C♭", "C", "C♯", "D♭", "D", "E♭", "E", "F♭", "F", "F♯", "G♭", "G", "A♭♭",
        ////                "A♭", "A", "B♭");
        ////        case "B":
        ////            return new Interval("B", "C", "C♯", "C♯♯", "D", "D♯", "E", "E♯", "F", "F♯", "F♯♯", "G", "G♯", "A♭",
        ////                "A", "A♯", "B");

        ////        default:
        ////            throw new ArgumentOutOfRangeException();
        ////    }
        ////}

        ////public int FromNote(Pitch relativePitch)
        ////{
        ////    var value = PitchAbsolute;
        ////    var relative = relativePitch.PitchAbsolute;

        ////    return relative > value
        ////        ? value - relative + 12
        ////        : value - relative - 12;
        ////}











        public static bool operator <(Pitch p1, Pitch p2)
            => p1?.MidiPitch < p2?.MidiPitch;

        public static bool operator <=(Pitch p1, Pitch p2)
            => p1?.MidiPitch <= p2?.MidiPitch;

        public static bool operator >(Pitch p1, Pitch p2)
            => p1?.MidiPitch > p2?.MidiPitch;

        public static bool operator >=(Pitch p1, Pitch p2)
            => p1?.MidiPitch >= p2?.MidiPitch;

        public static Pitch operator +(Pitch pitch, Interval interval)
            => pitch.Translate(interval, MidiPitchTranslationMode.Auto);

        //public static Pitch operator -(Pitch pitch, Interval interval)
        //    => pitch.Translate(interval.MakeDescending(), MidiPitchTranslationMode.Auto);

        public static int CalculateMidiPitch(string stepName, int alter, int octave)
        {
            int num;
            switch (stepName)
            {
                case "A":
                    num = 21;
                    break;
                case "B":
                    num = 23;
                    break;
                case "C":
                    num = 24;
                    break;
                case "D":
                    num = 26;
                    break;
                case "E":
                    num = 28;
                    break;
                case "F":
                    num = 29;
                    break;
                case "G":
                    num = 31;
                    break;
                default:
                    return 0;
            }

            return (stepName == "A" || stepName == "B"
                ? (octave * 12) + num
                : (octave - 1) * 12) + num + alter;
        }

        public static IEnumerable<Pitch> ChromaticRange(
            Pitch p1, Pitch p2, MidiPitchTranslationMode translationMode)
        {
            if (p1 == p2)
            {
                yield return p1;
            }

            var direction = p1 < p2 ? 1 : -1;
            var pitch = p1;

            while (pitch != p2)
            {
                yield return pitch = FromMidiPitch(pitch.MidiPitch + direction, translationMode);
            }
        }

        public static int FrequencyToMidiPitch(double freq)
        {
            var num = 0.0;
            while (freq >= 27.5 * Math.Pow(2.0, 0.0277777779847384) * Math.Pow(2.0, num / 12.0) || freq <
                   27.5 * Math.Pow(2.0, -0.0555555559694767) * Math.Pow(2.0, num / 12.0))
            {
                ++num;
                if (num > 100.0)
                {
                    break;
                }
            }

            return (int)num + 21;
        }

        public static double MidiPitchToFrequency(int midiPitch)
        {
            if (midiPitch < 0 || midiPitch > 127)
            {
                throw new ArgumentOutOfRangeException(nameof(midiPitch));
            }

            return Math.Round(440d / 32 * Math.Pow(2, (double)(midiPitch - 9) / 12), 2);
        }

        public static Pitch FromMidiPitch(int midiPitch, MidiPitchTranslationMode mode)
        {
            var pitch = new Pitch();
            var midiPitch1 = midiPitch;
            var num = (int)mode;
            pitch.ApplyMidiPitch(midiPitch1, (MidiPitchTranslationMode)num);
            return pitch;
        }

        public static Pitch FromStep(Step step, int octaveNumber = 4)
        {
            var pitch = new Pitch
            {
                Name = step.Name,
                Accidental = step.Accidental,
                MidiPitch = _pitches[step.Name.Name] + step.Accidental.Value + ((octaveNumber - 4) * 12),
                Octave = octaveNumber
            };
            return pitch;
        }

        public static int StepDistance(Pitch p1, Pitch p2)
            => p1.Name.StepNumber - 1 + (p1.Octave * 7) - (p2.Name.StepNumber - 1 + (p2.Octave * 7));

        public static int StepDistance(IHasPitch h1, Pitch p2)
            => StepDistance(h1.Pitch, p2);

        public static int StepDistance(Pitch p1, IHasPitch h2)
            => StepDistance(p1, h2.Pitch);

        public static int StepDistance(IHasPitch h1, IHasPitch h2)
            => StepDistance(h1.Pitch, h2.Pitch);

        public void ApplyMidiPitch(int midiPitch, MidiPitchTranslationMode mode)
        {
            var num = midiPitch;
            while (num > 32)
            {
                num -= 12;
            }

            switch (mode)
            {
                case MidiPitchTranslationMode.Auto:
                    switch (num)
                    {
                        case 21:
                            Name = new StepNameA();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 22:
                            Name = new StepNameB();
                            Accidental = new StepAccidentalFlat();
                            break;
                        case 23:
                            Name = new StepNameB();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 24:
                            Name = new StepNameC();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 25:
                            Name = new StepNameC();
                            Accidental = new StepAccidentalSharp();
                            break;
                        case 26:
                            Name = new StepNameD();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 27:
                            Name = new StepNameE();
                            Accidental = new StepAccidentalFlat();
                            break;
                        case 28:
                            Name = new StepNameE();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 29:
                            Name = new StepNameF();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 30:
                            Name = new StepNameF();
                            Accidental = new StepAccidentalSharp();
                            break;
                        case 31:
                            Name = new StepNameG();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 32:
                            Name = new StepNameG();
                            Accidental = new StepAccidentalSharp();
                            break;
                    }
                    break;
                case MidiPitchTranslationMode.Sharps:
                    switch (num)
                    {
                        case 21:
                            Name = new StepNameA();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 22:
                            Name = new StepNameA();
                            Accidental = new StepAccidentalSharp();
                            break;
                        case 23:
                            Name = new StepNameB();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 24:
                            Name = new StepNameC();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 25:
                            Name = new StepNameC();
                            Accidental = new StepAccidentalSharp();
                            break;
                        case 26:
                            Name = new StepNameD();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 27:
                            Name = new StepNameD();
                            Accidental = new StepAccidentalSharp();
                            break;
                        case 28:
                            Name = new StepNameE();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 29:
                            Name = new StepNameF();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 30:
                            Name = new StepNameF();
                            Accidental = new StepAccidentalSharp();
                            break;
                        case 31:
                            Name = new StepNameG();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 32:
                            Name = new StepNameG();
                            Accidental = new StepAccidentalSharp();
                            break;
                    }
                    break;
                case MidiPitchTranslationMode.Flats:
                    switch (num)
                    {
                        case 21:
                            Name = new StepNameA();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 22:
                            Name = new StepNameB();
                            Accidental = new StepAccidentalFlat();
                            break;
                        case 23:
                            Name = new StepNameB();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 24:
                            Name = new StepNameC();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 25:
                            Name = new StepNameD();
                            Accidental = new StepAccidentalFlat();
                            break;
                        case 26:
                            Name = new StepNameD();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 27:
                            Name = new StepNameE();
                            Accidental = new StepAccidentalFlat();
                            break;
                        case 28:
                            Name = new StepNameE();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 29:
                            Name = new StepNameF();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 30:
                            Name = new StepNameG();
                            Accidental = new StepAccidentalFlat();
                            break;
                        case 31:
                            Name = new StepNameG();
                            Accidental = new StepAccidentalNatural();
                            break;
                        case 32:
                            Name = new StepNameA();
                            Accidental = new StepAccidentalFlat();
                            break;
                    }
                    break;
                default:
                    throw new NotImplementedException("Unsupported midi pitch translation mode.");
            }

            if (midiPitch < 24)
            {
                Octave = 0;
            }
            else if (midiPitch < 36)
            {
                Octave = 1;
            }
            else if (midiPitch < 48)
            {
                Octave = 2;
            }
            else if (midiPitch < 60)
            {
                Octave = 3;
            }
            else if (midiPitch < 72)
            {
                Octave = 4;
            }
            else if (midiPitch < 84)
            {
                Octave = 5;
            }
            else if (midiPitch < 96)
            {
                Octave = 6;
            }
            else if (midiPitch < 108)
            {
                Octave = 7;
            }
            else if (midiPitch < 120)
            {
                Octave = 8;
            }

            MidiPitch = midiPitch;
        }

        public int CompareTo(Pitch other)
            => MidiPitch - other.MidiPitch;

        public Pitch Flatten()
            => new Pitch(Name.Name, Accidental.Value - 1, Octave);

        public Pitch OctaveDown()
            => new Pitch(Name.Name, Accidental.Value, Octave - 1);

        public Pitch OctaveUp()
            => new Pitch(Name.Name, Accidental.Value, Octave + 1);

        public Pitch Sharpen()
            => new Pitch(Name.Name, Accidental.Value + 1, Octave);

        public Step ToStep()
            => FromPitch(this);

        public override string ToString()
            => $"{Name}{Accidental.SignAscii}{Octave}";

        public Pitch Translate(Interval interval, MidiPitchTranslationMode mode)
        {
            return FromMidiPitch(MidiPitch + interval.Semitones, mode);
        }

        ////public TunedPitch Tune(TunedPitch standardPitch, TuningSystem tuningSystem)
        ////{
        ////    var allIntervalRatio = tuningSystem.AllIntervalRatios[new BoundInterval(standardPitch, this)];
        ////    return new TunedPitch(this, standardPitch.Frequency * UsefulMathHelpers.CentsToLinear(allIntervalRatio) * (Octave - standardPitch.Octave + 1));
        ////}

        public enum MidiPitchTranslationMode
        {
            Auto,
            Sharps,
            Flats
        }
    }
}