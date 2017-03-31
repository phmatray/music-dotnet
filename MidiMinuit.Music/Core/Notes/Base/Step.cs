namespace MidiMinuit.Music.Core.Notes
{
    using System;
    using System.Text.RegularExpressions;
    using NoteAccidentals;
    using NoteNames;

    public class Step : IEquatable<Step>
    {
        public StepName StepName { get; set; }

        public NoteAccidental Alter { get; set; }

        public static Step Cb => new Step { StepName = new StepNameC(), Alter = new NoteAccidentalFlat() };

        public static Step C => new Step { StepName = new StepNameC(), Alter = new NoteAccidentalNatural() };

        public static Step CSharp => new Step { StepName = new StepNameC(), Alter = new NoteAccidentalSharp() };

        public static Step Db => new Step { StepName = new StepNameD(), Alter = new NoteAccidentalFlat() };

        public static Step D => new Step { StepName = new StepNameD(), Alter = new NoteAccidentalNatural() };

        public static Step DSharp => new Step { StepName = new StepNameD(), Alter = new NoteAccidentalSharp() };

        public static Step Eb => new Step { StepName = new StepNameE(), Alter = new NoteAccidentalFlat() };

        public static Step E => new Step { StepName = new StepNameE(), Alter = new NoteAccidentalNatural() };

        public static Step ESharp => new Step { StepName = new StepNameE(), Alter = new NoteAccidentalSharp() };

        public static Step Fb => new Step { StepName = new StepNameF(), Alter = new NoteAccidentalFlat() };

        public static Step F => new Step { StepName = new StepNameF(), Alter = new NoteAccidentalNatural() };

        public static Step FSharp => new Step { StepName = new StepNameF(), Alter = new NoteAccidentalSharp() };

        public static Step Gb => new Step { StepName = new StepNameG(), Alter = new NoteAccidentalFlat() };

        public static Step G => new Step { StepName = new StepNameG(), Alter = new NoteAccidentalNatural() };

        public static Step GSharp => new Step { StepName = new StepNameG(), Alter = new NoteAccidentalSharp() };

        public static Step Ab => new Step { StepName = new StepNameA(), Alter = new NoteAccidentalFlat() };

        public static Step A => new Step { StepName = new StepNameA(), Alter = new NoteAccidentalNatural() };

        public static Step ASharp => new Step { StepName = new StepNameA(), Alter = new NoteAccidentalSharp() };

        public static Step Bb => new Step { StepName = new StepNameB(), Alter = new NoteAccidentalFlat() };

        public static Step B => new Step { StepName = new StepNameB(), Alter = new NoteAccidentalNatural() };

        public static Step BSharp => new Step { StepName = new StepNameB(), Alter = new NoteAccidentalSharp() };

        protected Step()
        {
        }


        /// <summary>
        ///     Initializes a new instance of the <see cref="Step" /> class.
        /// </summary>
        /// <param name="s">
        ///     The name of the note with its accidental.
        ///     ex: "C#" or "Db" or E...
        /// </param>
        /// <exception cref="ArgumentNullException">note</exception>
        /// <exception cref="ArgumentException">incorrect format</exception>
        public static implicit operator Step(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException(nameof(s));
            }

            if (!new Regex("^[A-Ga-g]((bb?|##?)|(♭♭?|♯♯?))?$").IsMatch(s))
            {
                throw new ArgumentException("incorrect format");
            }

            var stepName = new StepNameRepository()
                .GetByName(s[0].ToString());

            var accidental = new NoteAccidentalRepository()
                .GetBySymbol(s.Substring(1, s.Length - 1));

            return new Step { StepName = stepName, Alter = accidental };
        }

        public static implicit operator string(Step s)
        {
            return s.StepName.Name;
        }

        public static bool operator ==(Step s1, Step s2)
        {
            if (s1.StepName.Name.Equals(s2.StepName.Name, StringComparison.OrdinalIgnoreCase))
            {
                return s1.Alter == s2.Alter;
            }

            return false;
        }

        public static bool operator !=(Step s1, Step s2)
        {
            if (s1.StepName.Name.Equals(s2.StepName.Name, StringComparison.OrdinalIgnoreCase))
            {
                return s1.Alter != s2.Alter;
            }

            return true;
        }

        public static Step FromPitch(Pitch pitch)
        {
            return new Step { StepName = pitch.StepName, Alter = pitch.Alter };
        }

        public Pitch ToPitch(int octaveNumber = 4)
        {
            return Pitch.FromStep(this, octaveNumber);
        }

        public override string ToString()
        {
            return $"{StepName}{Alter.SignAscii}";
        }

        public bool Equals(Step other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(StepName, other.StepName) && Equals(Alter, other.Alter);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Step) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((StepName?.GetHashCode() ?? 0) * 397) ^ (Alter?.GetHashCode() ?? 0);
            }
        }
    }
}