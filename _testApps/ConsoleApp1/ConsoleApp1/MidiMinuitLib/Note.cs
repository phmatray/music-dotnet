namespace MidiMinuit.Lib.Core.Notes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;

    /// <summary>
    ///     Note Pitch (hauteur).
    ///     Cette classe représente la hauteur d'un son
    ///     http://programmers.stackexchange.com/questions/178817/oo-design-how-to-model-tonal-harmony
    /// </summary>
    public class Note : IEquatable<Note>, INotifyPropertyChanged
    {
        private NoteAccidental _accidental;
        private NoteName _name;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="name">The name of the note.</param>
        /// <param name="accidental">The accidental of the note.</param>
        public Note(NoteName name, NoteAccidental accidental = null)
        {
            Name = name;
            Accidental = accidental ?? NoteAccidental.Natural;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="note">
        ///     The name of the note with its accidental.
        ///     ex: "C#" or "Db" or E...
        /// </param>
        /// <exception cref="ArgumentNullException">note</exception>
        /// <exception cref="ArgumentException">incorrect format</exception>
        public Note(string note)
        {
            if (string.IsNullOrWhiteSpace(note))
            {
                throw new ArgumentNullException(nameof(note));
            }

            if (!new Regex("^[A-Ga-g]((bb?|##?)|(♭♭?|♯♯?))?$").IsMatch(note))
            {
                throw new ArgumentException("incorrect format");
            }

            Name = NoteName.GetName(note[0].ToString());
            Accidental = NoteAccidental.GetAccidental(note.Substring(1, note.Length - 1));
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="midiValue">
        ///     The midi value of the note.
        /// </param>
        /// <exception cref="ArgumentNullException">note</exception>
        /// <exception cref="ArgumentException">incorrect format</exception>
        public Note(int midiValue)
        {
            if (midiValue < 0 || midiValue > 127)
            {
                throw new ArgumentOutOfRangeException(nameof(midiValue));
            }

            switch (midiValue % 12)
            {
                case 0:
                    Name = NoteName.C;
                    Accidental = NoteAccidental.Natural;
                    break;
                case 1:
                    Name = NoteName.C;
                    Accidental = NoteAccidental.Sharp;
                    break;
                case 2:
                    Name = NoteName.D;
                    Accidental = NoteAccidental.Natural;
                    break;
                case 3:
                    Name = NoteName.D;
                    Accidental = NoteAccidental.Sharp;
                    break;
                case 4:
                    Name = NoteName.E;
                    Accidental = NoteAccidental.Natural;
                    break;
                case 5:
                    Name = NoteName.F;
                    Accidental = NoteAccidental.Natural;
                    break;
                case 6:
                    Name = NoteName.F;
                    Accidental = NoteAccidental.Sharp;
                    break;
                case 7:
                    Name = NoteName.G;
                    Accidental = NoteAccidental.Natural;
                    break;
                case 8:
                    Name = NoteName.G;
                    Accidental = NoteAccidental.Sharp;
                    break;
                case 9:
                    Name = NoteName.A;
                    Accidental = NoteAccidental.Natural;
                    break;
                case 10:
                    Name = NoteName.A;
                    Accidental = NoteAccidental.Sharp;
                    break;
                case 11:
                    Name = NoteName.B;
                    Accidental = NoteAccidental.Natural;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(midiValue));
            }
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="note">The note.</param>
        public Note(Note note)
            : this(note.Name, note.Accidental)
        {
        }

        public NoteName Name
        {
            get { return _name; }

            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public NoteAccidental Accidental
        {
            get { return _accidental; }

            set
            {
                _accidental = value;
                OnPropertyChanged();
            }
        }

        public int Pitch => Name.Value + Accidental.Value;

        public bool Equals(Note other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Name == other.Name && Accidental == other.Accidental;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static Note operator +(Note note, int semitone)
            => note.Add(semitone);

        public static Note operator -(Note note, int semitone)
            => note.Substract(semitone);

        public static bool operator ==(Note left, Note right)
            => Equals(left, right);

        public static bool operator !=(Note left, Note right)
            => !Equals(left, right);

        public static bool operator >(Note left, Note right)
            => left.Pitch > right.Pitch;

        public static bool operator <(Note left, Note right)
            => left.Pitch < right.Pitch;

        public static Note GetNoteSharp(int value)
        {
            if (value < 0)
            {
                value += 12;
            }

            switch (value)
            {
                case 0:
                    return new Note(NoteName.C);
                case 1:
                    return new Note(NoteName.C, NoteAccidental.Sharp);
                case 2:
                    return new Note(NoteName.D);
                case 3:
                    return new Note(NoteName.D, NoteAccidental.Sharp);
                case 4:
                    return new Note(NoteName.E);
                case 5:
                    return new Note(NoteName.F);
                case 6:
                    return new Note(NoteName.F, NoteAccidental.Sharp);
                case 7:
                    return new Note(NoteName.G);
                case 8:
                    return new Note(NoteName.G, NoteAccidental.Sharp);
                case 9:
                    return new Note(NoteName.A);
                case 10:
                    return new Note(NoteName.A, NoteAccidental.Sharp);
                case 11:
                    return new Note(NoteName.B);
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public static Note GetNoteFlat(int value)
        {
            switch (value)
            {
                case 0:
                    return new Note(NoteName.C);
                case 1:
                    return new Note(NoteName.D, NoteAccidental.Flat);
                case 2:
                    return new Note(NoteName.D);
                case 3:
                    return new Note(NoteName.E, NoteAccidental.Flat);
                case 4:
                    return new Note(NoteName.E);
                case 5:
                    return new Note(NoteName.F);
                case 6:
                    return new Note(NoteName.G, NoteAccidental.Flat);
                case 7:
                    return new Note(NoteName.G);
                case 8:
                    return new Note(NoteName.A, NoteAccidental.Flat);
                case 9:
                    return new Note(NoteName.A);
                case 10:
                    return new Note(NoteName.B, NoteAccidental.Flat);
                case 11:
                    return new Note(NoteName.B);
                default:
                    throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public static List<Note> GetNotesSharp()
        {
            return Enumerable
                .Range(0, 12)
                .Select(GetNoteSharp)
                .ToList();
        }

        public static List<Note> GetNotesFlat()
        {
            return Enumerable
                .Range(0, 12)
                .Select(GetNoteFlat)
                .ToList();
        }

        public static List<Note> GetNotesNatural()
        {
            return new[] { 0, 2, 4, 5, 7, 9, 11 }
                .Select(GetNoteFlat)
                .ToList();
        }

        public static List<Note> GetNotes(params string[] tuning)
        {
            var notes = tuning
                .Select((n, i) => new Note(tuning[i]))
                .ToList();

            return new List<Note>(notes);
        }

        public Note Add(int semitone)
        {
            return GetNoteSharp((Pitch + semitone) % 12);
        }

        public Note Substract(int semitone)
        {
            return Add(-semitone);
        }

        public double GetFrequency(int octave = 4)
        {
            // http://blog.jerome.rouaix.eu/2009/09/la-formule-de-la-frequence-exacte-des.html
            // Dans cette formule 0=La, donc -9 sur le pitch pour rétabli 0=Do
            var pitch = Pitch;
            var absolutePicth = octave + (pitch - 9) / 12d;
            var noteFrequency = Math.Pow(2, absolutePicth + 6) - 9d * Math.Pow(2, absolutePicth);
            var result = Math.Round(noteFrequency, 2);

            return result;
        }

        public Note ToFlat()
        {
            return GetNoteFlat(Pitch);
        }

        public Note ToSharp()
        {
            return GetNoteSharp(Pitch);
        }

        public int FromNote(Note relativeNote)
        {
            var value = Pitch;
            var relative = relativeNote.Pitch;

            return relative > value
                ? value - relative + 12
                : value - relative - 12;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((Note)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Name.Value * 397) ^ Accidental.Value;
            }
        }

        public override string ToString()
        {
            return $"{Name}{Accidental}";
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

namespace MidiMinuit.Lib.Core.Notes
{
    using System;

    public sealed class NoteAccidental
    {
        private NoteAccidental(int value, int order, string name, string symbol)
        {
            Value = value;
            Order = order;
            Name = name;
            Symbol = symbol;
        }

        /// <summary>
        ///     Gets Natural
        /// </summary>
        public static NoteAccidental Natural { get; }
            = new NoteAccidental(0, 0, nameof(Natural), string.Empty);

        /// <summary>
        ///     Gets bémol
        /// </summary>
        public static NoteAccidental Flat { get; }
            = new NoteAccidental(-1, 1, nameof(Flat), "♭");

        /// <summary>
        ///     Gets dièse
        /// </summary>
        public static NoteAccidental Sharp { get; }
            = new NoteAccidental(1, 2, nameof(Sharp), "♯");

        /// <summary>
        ///     Gets double bémol
        /// </summary>
        public static NoteAccidental DoubleFlat { get; }
            = new NoteAccidental(-2, 3, nameof(DoubleFlat), "♭♭");

        /// <summary>
        ///     Gets double dièse
        /// </summary>
        public static NoteAccidental DoubleSharp { get; }
            = new NoteAccidental(2, 4, nameof(DoubleSharp), "♯♯");

        public int Value { get; }

        public int Order { get; }

        public string Name { get; }

        public string Symbol { get; }

        public static NoteAccidental GetAccidental(string accidental)
        {
            if (accidental.Length < 0 || accidental.Length > 2)
            {
                throw new ArgumentException("invalid format");
            }

            switch (accidental.ToLowerInvariant())
            {
                case "":
                    return Natural;
                case "b":
                case "♭":
                    return Flat;
                case "#":
                case "♯":
                    return Sharp;
                case "bb":
                case "♭♭":
                    return DoubleFlat;
                case "##":
                case "♯♯":
                    return DoubleSharp;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
            => Symbol;
    }
}

namespace MidiMinuit.Lib.Core.Notes
{
    using System;

    public sealed class NoteName
    {
        private NoteName(int value, int order, string name, string nameLatin)
        {
            Value = value;
            Order = order;
            Name = name;
            NameLatin = nameLatin;
        }

        public static NoteName C { get; }
            = new NoteName(0, 1, nameof(C), "Do");

        public static NoteName D { get; }
            = new NoteName(2, 2, nameof(D), "Ré");

        public static NoteName E { get; }
            = new NoteName(4, 3, nameof(E), "Mi");

        public static NoteName F { get; }
            = new NoteName(5, 4, nameof(F), "Fa");

        public static NoteName G { get; }
            = new NoteName(7, 5, nameof(G), "Sol");

        public static NoteName A { get; }
            = new NoteName(9, 6, nameof(A), "La");

        public static NoteName B { get; }
            = new NoteName(11, 7, nameof(B), "Si");

        public int Value { get; }

        public int Order { get; }

        public string Name { get; }

        public string NameLatin { get; }

        public static NoteName GetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (name.Length != 1)
            {
                throw new ArgumentException("invalid format");
            }

            switch (name.ToUpper())
            {
                case "C":
                    return C;
                case "D":
                    return D;
                case "E":
                    return E;
                case "F":
                    return F;
                case "G":
                    return G;
                case "A":
                    return A;
                case "B":
                    return B;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
            => Name;
    }
}