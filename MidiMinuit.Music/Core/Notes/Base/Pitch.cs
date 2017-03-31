using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.NoteAccidentals;
using MidiMinuit.Music.Core.NoteNames;
using MidiMinuit.Music.Core.Tuning;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Core.Notes
{
    /// <summary>
    ///     Note Pitch (hauteur).
    ///     Cette classe représente la hauteur d'un son
    ///     http://programmers.stackexchange.com/questions/178817/oo-design-how-to-model-tonal-harmony
    /// </summary>
    public class Pitch
        : Step, IComparable<Pitch>
    {
        private static Dictionary<string, int> _pitches
            = new StepNameFactory()
                .CreateAllNoteNames()
                .ToDictionary(x => x.Name, x => x.MidiPitch);

        public static Pitch A1 => FromStep(A, 1);

        public static Pitch A2 => FromStep(A, 2);

        public static Pitch A3 => FromStep(A, 3);

        public static Pitch A4 => FromStep(A, 4);

        public static Pitch A5 => FromStep(A, 5);

        public static Pitch A6 => FromStep(A, 6);

        public static Pitch Ab1 => FromStep(Ab, 1);

        public static Pitch Ab2 => FromStep(Ab, 2);

        public static Pitch Ab3 => FromStep(Ab, 3);

        public static Pitch ASharp1 => FromStep(ASharp, 1);

        public static Pitch ASharp2 => FromStep(ASharp, 2);

        public static Pitch ASharp3 => FromStep(ASharp, 3);

        public static Pitch ASharp4 => FromStep(ASharp, 4);

        public static Pitch ASharp5 => FromStep(ASharp, 5);

        public static Pitch ASharp6 => FromStep(ASharp, 6);

        public static Pitch B1 => FromStep(B, 1);

        public static Pitch B2 => FromStep(B, 2);

        public static Pitch B3 => FromStep(B, 3);

        public static Pitch B4 => FromStep(B, 4);

        public static Pitch B5 => FromStep(B, 5);

        public static Pitch B6 => FromStep(B, 6);

        public static Pitch Bb1 => FromStep(Bb, 1);

        public static Pitch Bb2 => FromStep(Bb, 2);

        public static Pitch Bb3 => FromStep(Bb, 3);

        public static Pitch BSharp1 => FromStep(BSharp, 1);

        public static Pitch BSharp2 => FromStep(BSharp, 2);

        public static Pitch BSharp3 => FromStep(BSharp, 3);

        public static Pitch BSharp4 => FromStep(BSharp, 4);

        public static Pitch BSharp5 => FromStep(BSharp, 5);

        public static Pitch BSharp6 => FromStep(BSharp, 6);

        public static Pitch C1 => FromStep(C, 1);

        public static Pitch C2 => FromStep(C, 2);

        public static Pitch C3 => FromStep(C, 3);

        public static Pitch C4 => FromStep(C, 4);

        public static Pitch C5 => FromStep(C, 5);

        public static Pitch C6 => FromStep(C, 6);

        public static Pitch C7 => FromStep(C, 7);

        public static Pitch Cb1 => FromStep(Cb, 1);

        public static Pitch Cb2 => FromStep(Cb, 2);

        public static Pitch Cb3 => FromStep(Cb, 3);

        public static Pitch CSharp1 => FromStep(CSharp, 1);

        public static Pitch CSharp2 => FromStep(CSharp, 2);

        public static Pitch CSharp3 => FromStep(CSharp, 3);

        public static Pitch CSharp4 => FromStep(CSharp, 4);

        public static Pitch CSharp5 => FromStep(CSharp, 5);

        public static Pitch CSharp6 => FromStep(CSharp, 6);

        public static Pitch CSharp7 => FromStep(CSharp, 7);

        public static Pitch D1 => FromStep(D, 1);

        public static Pitch D2 => FromStep(D, 2);

        public static Pitch D3 => FromStep(D, 3);

        public static Pitch D4 => FromStep(D, 4);

        public static Pitch D5 => FromStep(D, 5);

        public static Pitch D6 => FromStep(D, 6);

        public static Pitch Db1 => FromStep(Db, 1);

        public static Pitch Db2 => FromStep(Db, 2);

        public static Pitch Db3 => FromStep(Db, 3);

        public static Pitch DSharp1 => FromStep(DSharp, 1);

        public static Pitch DSharp2 => FromStep(DSharp, 2);

        public static Pitch DSharp3 => FromStep(DSharp, 3);

        public static Pitch DSharp4 => FromStep(DSharp, 4);

        public static Pitch DSharp5 => FromStep(DSharp, 5);

        public static Pitch DSharp6 => FromStep(DSharp, 6);

        public static Pitch E1 => FromStep(E, 1);

        public static Pitch E2 => FromStep(E, 2);

        public static Pitch E3 => FromStep(E, 3);

        public static Pitch E4 => FromStep(E, 4);

        public static Pitch E5 => FromStep(E, 5);

        public static Pitch E6 => FromStep(E, 6);

        public static Pitch Eb1 => FromStep(Eb, 1);

        public static Pitch Eb2 => FromStep(Eb, 2);

        public static Pitch Eb3 => FromStep(Eb, 3);

        public static Pitch ESharp4 => FromStep(ESharp, 4);

        public static Pitch ESharp5 => FromStep(ESharp, 5);

        public static Pitch ESharp6 => FromStep(ESharp, 6);

        public static Pitch F1 => FromStep(F, 1);

        public static Pitch F2 => FromStep(F, 2);

        public static Pitch F3 => FromStep(F, 3);

        public static Pitch F4 => FromStep(F, 4);

        public static Pitch F5 => FromStep(F, 5);

        public static Pitch F6 => FromStep(F, 6);

        public static Pitch Fb1 => FromStep(Fb, 1);

        public static Pitch Fb2 => FromStep(Fb, 2);

        public static Pitch Fb3 => FromStep(Fb, 3);

        public static Pitch FSharp1 => FromStep(FSharp, 1);

        public static Pitch FSharp2 => FromStep(FSharp, 2);

        public static Pitch FSharp3 => FromStep(FSharp, 3);

        public static Pitch FSharp4 => FromStep(FSharp, 4);

        public static Pitch FSharp5 => FromStep(FSharp, 5);

        public static Pitch FSharp6 => FromStep(FSharp, 6);

        public static Pitch G1 => FromStep(G, 1);

        public static Pitch G2 => FromStep(G, 2);

        public static Pitch G3 => FromStep(G, 3);

        public static Pitch G4 => FromStep(G, 4);

        public static Pitch G5 => FromStep(G, 5);

        public static Pitch G6 => FromStep(G, 6);

        public static Pitch Gb1 => FromStep(Gb, 1);

        public static Pitch Gb2 => FromStep(Gb, 2);

        public static Pitch Gb3 => FromStep(Gb, 3);

        public static Pitch GSharp1 => FromStep(GSharp, 1);

        public static Pitch GSharp2 => FromStep(GSharp, 2);

        public static Pitch GSharp3 => FromStep(GSharp, 3);

        public static Pitch GSharp4 => FromStep(GSharp, 4);

        public static Pitch GSharp5 => FromStep(GSharp, 5);

        public static Pitch GSharp6 => FromStep(GSharp, 6);

        public Pitch(string stepName, int alter, int octaveNumber)
        {
            StepName = stepName;
            Alter = alter;
            MidiPitch = _pitches[stepName] + alter + ((octaveNumber - 4) * 12);
            Octave = octaveNumber;
        }

        protected Pitch()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="name">The name of the note.</param>
        /// <param name="accidental">The accidental of the note.</param>
        public Pitch(StepName name = null, NoteAccidental accidental = null)
        {
            Name = name ?? new StepNameC();
            Accidental = accidental ?? new NoteAccidentalNatural();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="name">The name of the note.</param>
        /// <param name="accidental">The accidental of the note.</param>
        public Pitch(StepNameAlias name, NoteAccidentalAlias accidental = NoteAccidentalAlias.Natural)
        {
            Name = new StepNameRepository().Get(name);
            Accidental = new NoteAccidentalRepository().Get(accidental);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="note">
        ///     The name of the note with its accidental.
        ///     ex: "C#" or "Db" or E...
        /// </param>
        /// <exception cref="ArgumentNullException">note</exception>
        /// <exception cref="ArgumentException">incorrect format</exception>
        public Pitch(string note)
        {
            if (string.IsNullOrWhiteSpace(note))
            {
                throw new ArgumentNullException(nameof(note));
            }

            if (!new Regex("^[A-Ga-g]((bb?|##?)|(♭♭?|♯♯?))?$").IsMatch(note))
            {
                throw new ArgumentException("incorrect format");
            }

            Name = new StepNameRepository()
                .GetByName(note[0].ToString());

            Accidental = new NoteAccidentalRepository()
                .GetBySymbol(note.Substring(1, note.Length - 1));
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="midiValue">
        ///     The midi value of the note.
        /// </param>
        /// <exception cref="ArgumentNullException">note</exception>
        /// <exception cref="ArgumentException">incorrect format</exception>
        public Pitch(int midiValue)
        {
            if (midiValue < 0 || midiValue > 127)
            {
                throw new ArgumentOutOfRangeException(nameof(midiValue));
            }

            switch (midiValue % 12)
            {
                case 0:
                    Name = new StepNameC();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 1:
                    Name = new StepNameC();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 2:
                    Name = new StepNameD();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 3:
                    Name = new StepNameD();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 4:
                    Name = new StepNameE();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 5:
                    Name = new StepNameF();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 6:
                    Name = new StepNameF();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 7:
                    Name = new StepNameG();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 8:
                    Name = new StepNameG();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 9:
                    Name = new StepNameA();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 10:
                    Name = new StepNameA();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 11:
                    Name = new StepNameB();
                    Accidental = new NoteAccidentalNatural();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(midiValue));
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="pitch">The note.</param>
        public Pitch(Pitch pitch)
            : this(pitch.Name, pitch.Accidental)
        {
        }





        public StepName Name { get; }

        public NoteAccidental Accidental { get; }



        public int MidiPitch { get; set; }

        public int Octave { get; set; }





        public string Details
            => $"{Name}{Accidental}";

        ////public Interval Interval => GetInterval();

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

        public static Pitch GetNoteSharp(int value)
        {
            if (value < 0)
            {
                value += 12;
            }

            switch (value)
            {
                case 0:
                    return new Pitch(new StepNameC());
                case 1:
                    return new Pitch(new StepNameC(), new NoteAccidentalSharp());
                case 2:
                    return new Pitch(new StepNameD());
                case 3:
                    return new Pitch(new StepNameD(), new NoteAccidentalSharp());
                case 4:
                    return new Pitch(new StepNameE());
                case 5:
                    return new Pitch(new StepNameF());
                case 6:
                    return new Pitch(new StepNameF(), new NoteAccidentalSharp());
                case 7:
                    return new Pitch(new StepNameG());
                case 8:
                    return new Pitch(new StepNameG(), new NoteAccidentalSharp());
                case 9:
                    return new Pitch(new StepNameA());
                case 10:
                    return new Pitch(new StepNameA(), new NoteAccidentalSharp());
                case 11:
                    return new Pitch(new StepNameB());
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public static Pitch GetNoteFlat(int value)
        {
            switch (value)
            {
                case 0:
                    return new Pitch(new StepNameC());
                case 1:
                    return new Pitch(new StepNameD(), new NoteAccidentalFlat());
                case 2:
                    return new Pitch(new StepNameD());
                case 3:
                    return new Pitch(new StepNameE(), new NoteAccidentalFlat());
                case 4:
                    return new Pitch(new StepNameE());
                case 5:
                    return new Pitch(new StepNameF());
                case 6:
                    return new Pitch(new StepNameG(), new NoteAccidentalFlat());
                case 7:
                    return new Pitch(new StepNameG());
                case 8:
                    return new Pitch(new StepNameA(), new NoteAccidentalFlat());
                case 9:
                    return new Pitch(new StepNameA());
                case 10:
                    return new Pitch(new StepNameB(), new NoteAccidentalFlat());
                case 11:
                    return new Pitch(new StepNameB());
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public static List<Pitch> GetNotesSharp()
        {
            return Enumerable
                .Range(0, 12)
                .Select(GetNoteSharp)
                .ToList();
        }

        public static List<Pitch> GetNotesFlat()
        {
            return Enumerable
                .Range(0, 12)
                .Select(GetNoteFlat)
                .ToList();
        }

        public static List<Pitch> GetNotesNatural()
        {
            return new[] { 0, 2, 4, 5, 7, 9, 11 }
                .Select(GetNoteFlat)
                .ToList();
        }

        public static List<Pitch> GetNotes(params string[] tuning)
        {
            var notes = tuning
                .Select((n, i) => new Pitch(tuning[i]))
                .ToList();

            return new List<Pitch>(notes);
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

        public Pitch Add(int semitone)
            => GetNoteSharp((PitchAbsolute + semitone) % 12);

        public Pitch Substract(int semitone)
            => Add(-semitone);

        public double GetFrequency(int octave = 4)
        {
            // http://blog.jerome.rouaix.eu/2009/09/la-formule-de-la-frequence-exacte-des.html
            // Dans cette formule 0=La, donc -9 sur le pitch pour rétabli 0=Do
            var pitch = PitchAbsolute;
            var absolutePicth = octave + (pitch - 9) / 12d;
            var noteFrequency = Math.Pow(2, absolutePicth + 6) - 9d * Math.Pow(2, absolutePicth);
            var result = Math.Round(noteFrequency, 2);

            return result;
        }

        public Pitch ToFlat()
            => GetNoteFlat(PitchAbsolute);

        public Pitch ToSharp()
            => GetNoteSharp(PitchAbsolute);

        public int FromNote(Pitch relativePitch)
        {
            var value = PitchAbsolute;
            var relative = relativePitch.PitchAbsolute;

            return relative > value
                ? value - relative + 12
                : value - relative - 12;
        }











        public static bool operator <(Pitch p1, Pitch p2)
            => p1.MidiPitch < p2.MidiPitch;

        public static bool operator <=(Pitch p1, Pitch p2)
            => p1.MidiPitch <= p2.MidiPitch;

        public static bool operator ==(Pitch p1, Pitch p2)
            => p1.MidiPitch == p2.MidiPitch;

        public static bool operator !=(Pitch p1, Pitch p2)
            => p1.MidiPitch != p2.MidiPitch;

        public static bool operator >(Pitch p1, Pitch p2)
            => p1.MidiPitch > p2.MidiPitch;

        public static bool operator >=(Pitch p1, Pitch p2)
            => p1.MidiPitch >= p2.MidiPitch;

        public static Pitch operator +(Pitch pitch, Interval interval)
            => pitch.Translate(interval, MidiPitchTranslationMode.Auto);

        public static Pitch operator -(Pitch pitch, Interval interval)
            => pitch.Translate(interval.MakeDescending(), MidiPitchTranslationMode.Auto);

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
            var pitch = new Pitch();
            var stepName = step.StepName;
            pitch.StepName = stepName;
            var alter = step.Alter;
            pitch.Alter = alter;
            var num1 = _pitches[step.StepName.Name] + step.Alter.Value + ((octaveNumber - 4) * 12);
            pitch.MidiPitch = num1;
            var num2 = octaveNumber;
            pitch.Octave = num2;
            return pitch;
        }

        public static int StepDistance(Pitch p1, Pitch p2)
            => p1.StepName.StepNumber - 1 + (p1.Octave * 7) - (p2.StepName.StepNumber - 1 + (p2.Octave * 7));

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
                            StepName = new StepNameA();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 22:
                            StepName = new StepNameB();
                            Alter = new NoteAccidentalFlat();
                            break;
                        case 23:
                            StepName = new StepNameB();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 24:
                            StepName = new StepNameC();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 25:
                            StepName = new StepNameC();
                            Alter = new NoteAccidentalSharp();
                            break;
                        case 26:
                            StepName = new StepNameD();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 27:
                            StepName = new StepNameE();
                            Alter = new NoteAccidentalFlat();
                            break;
                        case 28:
                            StepName = new StepNameE();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 29:
                            StepName = new StepNameF();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 30:
                            StepName = new StepNameF();
                            Alter = new NoteAccidentalSharp();
                            break;
                        case 31:
                            StepName = new StepNameG();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 32:
                            StepName = new StepNameG();
                            Alter = new NoteAccidentalSharp();
                            break;
                    }
                    break;
                case MidiPitchTranslationMode.Sharps:
                    switch (num)
                    {
                        case 21:
                            StepName = new StepNameA();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 22:
                            StepName = new StepNameA();
                            Alter = new NoteAccidentalSharp();
                            break;
                        case 23:
                            StepName = new StepNameB();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 24:
                            StepName = new StepNameC();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 25:
                            StepName = new StepNameC();
                            Alter = new NoteAccidentalSharp();
                            break;
                        case 26:
                            StepName = new StepNameD();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 27:
                            StepName = new StepNameD();
                            Alter = new NoteAccidentalSharp();
                            break;
                        case 28:
                            StepName = new StepNameE();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 29:
                            StepName = new StepNameF();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 30:
                            StepName = new StepNameF();
                            Alter = new NoteAccidentalSharp();
                            break;
                        case 31:
                            StepName = new StepNameG();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 32:
                            StepName = new StepNameG();
                            Alter = new NoteAccidentalSharp();
                            break;
                    }
                    break;
                case MidiPitchTranslationMode.Flats:
                    switch (num)
                    {
                        case 21:
                            StepName = new StepNameA();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 22:
                            StepName = new StepNameB();
                            Alter = new NoteAccidentalFlat();
                            break;
                        case 23:
                            StepName = new StepNameB();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 24:
                            StepName = new StepNameC();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 25:
                            StepName = new StepNameD();
                            Alter = new NoteAccidentalFlat();
                            break;
                        case 26:
                            StepName = new StepNameD();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 27:
                            StepName = new StepNameE();
                            Alter = new NoteAccidentalFlat();
                            break;
                        case 28:
                            StepName = new StepNameE();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 29:
                            StepName = new StepNameF();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 30:
                            StepName = new StepNameG();
                            Alter = new NoteAccidentalFlat();
                            break;
                        case 31:
                            StepName = new StepNameG();
                            Alter = new NoteAccidentalNatural();
                            break;
                        case 32:
                            StepName = new StepNameA();
                            Alter = new NoteAccidentalFlat();
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
            => new Pitch(StepName.Name, Alter.Value - 1, Octave);

        public Pitch OctaveDown()
            => new Pitch(StepName.Name, Alter.Value, Octave - 1);

        public Pitch OctaveUp()
            => new Pitch(StepName.Name, Alter.Value, Octave + 1);

        public Pitch Sharpen()
            => new Pitch(StepName.Name, Alter.Value + 1, Octave);

        public Step ToStep()
            => FromPitch(this);

        ////public override string ToString()
        ////    => $"{Name}{Accidental}{Octave}";

        public override string ToString()
            => $"{StepName}{Alter.SignAscii}{Octave}";

        ////public Pitch Translate(Interval interval, MidiPitchTranslationMode mode)
        ////{
        ////    return FromMidiPitch(MidiPitch + interval.Halftones, mode);
        ////}

        ////public TunedPitch Tune(TunedPitch standardPitch, TuningSystem tuningSystem)
        ////{
        ////    var allIntervalRatio = tuningSystem.AllIntervalRatios[new BoundInterval(standardPitch, this)];
        ////    return new TunedPitch(this, standardPitch.Frequency * UsefulMathHelpers.CentsToLinear(allIntervalRatio) * (Octave - standardPitch.Octave + 1));
        ////}

        public enum MidiPitchTranslationMode
        {
            Auto,
            Sharps,
            Flats,
        }
    }
}