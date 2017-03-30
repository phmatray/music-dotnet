namespace MidiMinuit.Lib.Core.Notes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using NoteAccidentals;
    using NoteNames;


    /// <summary>
    ///     Note Pitch (hauteur).
    ///     Cette classe représente la hauteur d'un son
    ///     http://programmers.stackexchange.com/questions/178817/oo-design-how-to-model-tonal-harmony
    /// </summary>
    public class Pitch
        : Step, IComparable<Pitch>
    {
        private static Dictionary<string, int> _pitches = new Dictionary<string, int>
        {
            {"C", 60},
            {"D", 62},
            {"E", 64},
            {"F", 65},
            {"G", 67},
            {"A", 69},
            {"B", 71}
        };

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="name">The name of the note.</param>
        /// <param name="accidental">The accidental of the note.</param>
        public Pitch(NoteName name = null, NoteAccidental accidental = null)
        {
            Name = name ?? new NoteNameC();
            Accidental = accidental ?? new NoteAccidentalNatural();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pitch" /> class.
        /// </summary>
        /// <param name="name">The name of the note.</param>
        /// <param name="accidental">The accidental of the note.</param>
        public Pitch(NoteNameAlias name, NoteAccidentalAlias accidental = NoteAccidentalAlias.Natural)
        {
            Name = new NoteNameRepository().Get(name);
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

            Name = new NoteNameRepository()
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
                    Name = new NoteNameC();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 1:
                    Name = new NoteNameC();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 2:
                    Name = new NoteNameD();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 3:
                    Name = new NoteNameD();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 4:
                    Name = new NoteNameE();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 5:
                    Name = new NoteNameF();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 6:
                    Name = new NoteNameF();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 7:
                    Name = new NoteNameG();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 8:
                    Name = new NoteNameG();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 9:
                    Name = new NoteNameA();
                    Accidental = new NoteAccidentalNatural();
                    break;
                case 10:
                    Name = new NoteNameA();
                    Accidental = new NoteAccidentalSharp();
                    break;
                case 11:
                    Name = new NoteNameB();
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

        public NoteName Name { get; }

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
                var pitch = Name.Value + Accidental.Value;
                if (pitch < 0)
                {
                    pitch += 12;
                }

                return pitch;
            }
        }

        ////public static Note operator +(Note note, int semitone)
        ////    => note.Add(semitone);

        ////public static Note operator -(Note note, int semitone)
        ////    => note.Substract(semitone);

        ////public static bool operator ==(Note left, Note right)
        ////    => Equals(left, right);

        ////public static bool operator !=(Note left, Note right)
        ////    => !Equals(left, right);

        ////public static bool operator >(Note left, Note right)
        ////    => left.Pitch > right.Pitch;

        ////public static bool operator <(Note left, Note right)
        ////    => left.Pitch < right.Pitch;

        ////public bool Equals(Note other)
        ////{
        ////    if (ReferenceEquals(null, other))
        ////    {
        ////        return false;
        ////    }

        ////    if (ReferenceEquals(this, other))
        ////    {
        ////        return true;
        ////    }

        ////    return Name == other.Name && Accidental == other.Accidental;
        ////}

        public static Pitch GetNoteSharp(int value)
        {
            if (value < 0)
            {
                value += 12;
            }

            switch (value)
            {
                case 0:
                    return new Pitch(new NoteNameC());
                case 1:
                    return new Pitch(new NoteNameC(), new NoteAccidentalSharp());
                case 2:
                    return new Pitch(new NoteNameD());
                case 3:
                    return new Pitch(new NoteNameD(), new NoteAccidentalSharp());
                case 4:
                    return new Pitch(new NoteNameE());
                case 5:
                    return new Pitch(new NoteNameF());
                case 6:
                    return new Pitch(new NoteNameF(), new NoteAccidentalSharp());
                case 7:
                    return new Pitch(new NoteNameG());
                case 8:
                    return new Pitch(new NoteNameG(), new NoteAccidentalSharp());
                case 9:
                    return new Pitch(new NoteNameA());
                case 10:
                    return new Pitch(new NoteNameA(), new NoteAccidentalSharp());
                case 11:
                    return new Pitch(new NoteNameB());
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public static Pitch GetNoteFlat(int value)
        {
            switch (value)
            {
                case 0:
                    return new Pitch(new NoteNameC());
                case 1:
                    return new Pitch(new NoteNameD(), new NoteAccidentalFlat());
                case 2:
                    return new Pitch(new NoteNameD());
                case 3:
                    return new Pitch(new NoteNameE(), new NoteAccidentalFlat());
                case 4:
                    return new Pitch(new NoteNameE());
                case 5:
                    return new Pitch(new NoteNameF());
                case 6:
                    return new Pitch(new NoteNameG(), new NoteAccidentalFlat());
                case 7:
                    return new Pitch(new NoteNameG());
                case 8:
                    return new Pitch(new NoteNameA(), new NoteAccidentalFlat());
                case 9:
                    return new Pitch(new NoteNameA());
                case 10:
                    return new Pitch(new NoteNameB(), new NoteAccidentalFlat());
                case 11:
                    return new Pitch(new NoteNameB());
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

        ////public override bool Equals(object obj)
        ////{
        ////    if (ReferenceEquals(null, obj))
        ////    {
        ////        return false;
        ////    }

        ////    if (ReferenceEquals(this, obj))
        ////    {
        ////        return true;
        ////    }

        ////    if (obj.GetType() != GetType())
        ////    {
        ////        return false;
        ////    }

        ////    return Equals((Note)obj);
        ////}

        ////public override int GetHashCode()
        ////{
        ////    unchecked
        ////    {
        ////        return (Name.Value * 397) ^ Accidental.Value;
        ////    }
        ////}

        public override string ToString()
            => $"{Name}{Accidental}{Octave}";








        public int CompareTo(Pitch other)
        {
            return MidiPitch - other.MidiPitch;
        }




        ////public static Note operator +(Note pitch, Interval interval)
        ////{
        ////    return pitch.Translate(interval, MidiPitchTranslationMode.Auto);
        ////}

        ////public static Note operator -(Note pitch, Interval interval)
        ////{
        ////    return pitch.Translate(interval.MakeDescending(), MidiPitchTranslationMode.Auto);
        ////}

        public static Pitch FromStep(Step step, int octaveNumber = 4)
        {
            var pitch = new Pitch();
            var stepName = step.StepName;
            pitch.StepName = stepName;
            var alter = step.Alter;
            pitch.Alter = alter;
            var num1 = _pitches[step.StepName] + step.Alter + (octaveNumber - 4) * 12;
            pitch.MidiPitch = num1;
            var num2 = octaveNumber;
            pitch.Octave = num2;
            return pitch;
        }

        public static bool operator <(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch < p2.MidiPitch;
        }

        public static bool operator <=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch <= p2.MidiPitch;
        }

        public static bool operator ==(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch == p2.MidiPitch;
        }

        public static bool operator !=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch != p2.MidiPitch;
        }

        public static bool operator >(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch > p2.MidiPitch;
        }

        public static bool operator >=(Pitch p1, Pitch p2)
        {
            return p1.MidiPitch >= p2.MidiPitch;
        }
    }
}