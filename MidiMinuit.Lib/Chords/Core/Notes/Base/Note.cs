using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Tools.Extensions;

namespace MidiMinuit.Lib.Chords.Core.Notes.Base
{
    /// <summary>
    ///     Note Pitch (hauteur).
    ///     Cette classe représente la hauteur d'un son
    ///     http://programmers.stackexchange.com/questions/178817/oo-design-how-to-model-tonal-harmony
    /// </summary>
    public class Note : IEquatable<Note>, INotifyPropertyChanged
    {
        public static Note GetNoteSharp(int value)
        {
            if (value < 0)
            {
                value += 12;
            }

            switch (value)
            {
                case 0:
                    return new Note();
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
                    return new Note();
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
                    return NoteName.C;
                case "D":
                    return NoteName.D;
                case "E":
                    return NoteName.E;
                case "F":
                    return NoteName.F;
                case "G":
                    return NoteName.G;
                case "A":
                    return NoteName.A;
                case "B":
                    return NoteName.B;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static NoteAccidental GetAccidental(string accidental)
        {
            if (accidental.Length < 0 || accidental.Length > 2)
            {
                throw new ArgumentException("invalid format");
            }

            switch (accidental.ToLowerInvariant())
            {
                case "":
                    return NoteAccidental.Natural;
                case "b":
                    return NoteAccidental.Flat;
                case "#":
                    return NoteAccidental.Sharp;
                case "bb":
                    return NoteAccidental.DoubleFlat;
                case "##":
                    return NoteAccidental.DoubleSharp;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static Interval GetInterval(Note note)
        {
            // http://www.tabs4acoustic.com/forum-guitare/tableau-intervalles-et-gammes-majeure-et-mineures-t9478.html
            if (note == null)
            {
                throw new ArgumentNullException(nameof(note));
            }

            switch (note.ToString())
            {
                case "C":
                    return new Interval("C", "Db", "D", "D#", "Eb", "E", "F", "F#", "Gb", "G", "G#", "Ab", "A", "Bbb", "Bb", "B", "C");
                case "C#":
                    return new Interval("C#", "D", "D#", "D##", "E", "E#", "F#", "F##", "G", "G#", "G##", "A", "A#", "Bb", "B", "B#", "C#");
                case "Db":
                    return new Interval("Db", "Ebb", "Eb", "E", "Fb", "F", "Gb", "G", "Abb", "Ab", "A", "Bbb", "Bb", "Cbb", "Cb", "C", "Db");
                case "D":
                    return new Interval("D", "Eb", "E", "E#", "F", "F#", "G", "G#", "Ab", "A", "A#", "Bb", "B", "Cb", "C", "C#", "D");
                case "D#":
                    return new Interval("D#", "E", "E#", "E##", "F#", "F##", "G#", "G##", "A", "A#", "A##", "B", "B#", "C", "C#", "C##", "D#");
                case "Eb":
                    return new Interval("Eb", "Fb", "F", "F#", "Gb", "G", "Ab", "A", "Bbb", "Bb", "B", "Cb", "C", "Dbb", "Db", "D", "Eb");
                case "E":
                    return new Interval("E", "F", "F#", "F##", "G", "G#", "A", "A#", "Bb", "B", "B#", "C", "C#", "Db", "D", "D#", "E");
                case "F":
                    return new Interval("F", "Gb", "G", "G#", "Ab", "A", "Bb", "B", "Cb", "C", "C#", "Db", "D", "Ebb", "Eb", "E", "F");
                case "F#":
                    return new Interval("F#", "G", "G#", "G##", "A", "A#", "B", "B#", "C", "C#", "C##", "D", "D#", "Eb", "E", "E#", "F#");
                case "Gb":
                    return new Interval("Gb", "Abb", "Ab", "A", "Bbb", "Bb", "Cb", "C", "Dbb", "Db", "D", "Ebb", "Eb", "Fbb", "Fb", "F", "Gb");
                case "G":
                    return new Interval("G", "Ab", "A", "A#", "Bb", "B", "C", "C#", "Db", "D", "D#", "Eb", "E", "Fb", "F", "F#", "G");
                case "G#":
                    return new Interval("G#", "A", "A#", "A##", "B", "B#", "C#", "C##", "D", "D#", "D##", "E", "E#", "F", "F#", "F##", "G#");
                case "Ab":
                    return new Interval("Ab", "Bbb", "Bb", "B", "Cb", "C", "Db", "D", "Ebb", "Eb", "E", "Fb", "F", "Gbb", "Gb", "G", "Ab");
                case "A":
                    return new Interval("A", "Bb", "B", "B#", "C", "C#", "D", "D#", "Eb", "E", "E#", "F", "F#", "Gb", "G", "G#", "A");
                case "A#":
                    return new Interval("A#", "B", "B#", "B##", "C#", "C##", "D#", "D##", "E", "E#", "E##", "F#", "F##", "G", "G#", "G##", "A#");
                case "Bb":
                    return new Interval("Bb", "Cb", "C", "C#", "Db", "D", "Eb", "E", "Fb", "F", "F#", "Gb", "G", "Abb", "Ab", "A", "Bb");
                case "B":
                    return new Interval("B", "C", "C#", "C##", "D", "D#", "E", "E#", "F", "F#", "F##", "G", "G#", "Ab", "A", "A#", "B");

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static Note New(
            NoteName name = NoteName.C,
            NoteAccidental accidental = NoteAccidental.Natural)
        {
            return new Note(name, accidental);
        }

        public static Note New(string note)
        {
            return new Note(note);
        }

        public static Note New(int midiValue)
        {
            if (midiValue < 0 || midiValue > 127)
            {
                throw new ArgumentOutOfRangeException(nameof(midiValue));
            }

            switch (midiValue % 12)
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
                    return new Note(NoteName.B, NoteAccidental.Sharp);
                default:
                    throw new ArgumentOutOfRangeException(nameof(midiValue));
            }
        }

        private NoteName _name;
        private NoteAccidental _accidental;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="name">The name of the note.</param>
        /// <param name="accidental">The accidental of the note.</param>
        public Note(
            NoteName name = NoteName.C,
            NoteAccidental accidental = NoteAccidental.Natural)
        {
            Name = name;
            Accidental = accidental;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Note" /> class.
        /// </summary>
        /// <param name="note">
        ///     The name of the note with its accidental.
        ///     ex: "C#" or "Db" or E...
        /// </param>
        /// <exception cref="System.ArgumentNullException">note</exception>
        /// <exception cref="System.ArgumentException">incorrect format</exception>
        public Note(string note)
        {
            if (string.IsNullOrWhiteSpace(note))
            {
                throw new ArgumentNullException(nameof(note));
            }

            if (!new Regex("^[A-Ga-g](bb?|##?)?$").IsMatch(note))
            {
                throw new ArgumentException("incorrect format");
            }

            Name = GetName(note[0].ToString());
            Accidental = GetAccidental(note.Substring(1, note.Length - 1));
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
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public NoteAccidental Accidental
        {
            get
            {
                return _accidental;
            }

            set
            {
                _accidental = value;
                OnPropertyChanged();
            }
        }

        public Interval Interval => GetInterval(this);

        public int Pitch => Name.GetValue() + Accidental.GetValue();

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
            var absolutePicth = octave + ((pitch - 9) / 12d);
            var noteFrequency = Math.Pow(2, absolutePicth + 6) - (9d * Math.Pow(2, absolutePicth));
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
                return ((int)Name * 397) ^ (int)Accidental;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static Note operator +(Note note, int semitone)
        {
            return note.Add(semitone);
        }

        public static Note operator -(Note note, int semitone)
        {
            return note.Substract(semitone);
        }

        public static bool operator ==(Note left, Note right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Note left, Note right)
        {
            return !Equals(left, right);
        }

        public static bool operator >(Note left, Note right)
        {
            return left.Pitch > right.Pitch;
        }

        public static bool operator <(Note left, Note right)
        {
            return left.Pitch < right.Pitch;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Name);

            switch (Accidental)
            {
                case NoteAccidental.Natural:
                    break;
                case NoteAccidental.Flat:
                    sb.Append("b");
                    break;
                case NoteAccidental.Sharp:
                    sb.Append("#");
                    break;
                case NoteAccidental.DoubleFlat:
                    sb.Append("bb");
                    break;
                case NoteAccidental.DoubleSharp:
                    sb.Append("##");
                    break;
            }

            return sb.ToString();
        }
    }
}