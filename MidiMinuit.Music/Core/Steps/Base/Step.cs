using System;
using System.Text.RegularExpressions;
using MidiMinuit.Music.Core.Pitches;
using MidiMinuit.Music.Core.StepAccidentals;
using MidiMinuit.Music.Core.StepNames;

namespace MidiMinuit.Music.Core.Steps
{
    public class Step : IEquatable<Step>
    {
        public StepName Name { get; set; }

        public StepAccidental Accidental { get; set; }

        public static Step Cb => new Step { Name = StepNameAlias.C, Accidental = new StepAccidentalFlat() };

        public static Step C => new Step { Name = new StepNameC(), Accidental = new StepAccidentalNatural() };

        public static Step CSharp => new Step { Name = new StepNameC(), Accidental = new StepAccidentalSharp() };

        public static Step Db => new Step { Name = new StepNameD(), Accidental = new StepAccidentalFlat() };

        public static Step D => new Step { Name = new StepNameD(), Accidental = new StepAccidentalNatural() };

        public static Step DSharp => new Step { Name = new StepNameD(), Accidental = new StepAccidentalSharp() };

        public static Step Eb => new Step { Name = new StepNameE(), Accidental = new StepAccidentalFlat() };

        public static Step E => new Step { Name = new StepNameE(), Accidental = new StepAccidentalNatural() };

        public static Step ESharp => new Step { Name = new StepNameE(), Accidental = new StepAccidentalSharp() };

        public static Step Fb => new Step { Name = new StepNameF(), Accidental = new StepAccidentalFlat() };

        public static Step F => new Step { Name = new StepNameF(), Accidental = new StepAccidentalNatural() };

        public static Step FSharp => new Step { Name = new StepNameF(), Accidental = new StepAccidentalSharp() };

        public static Step Gb => new Step { Name = new StepNameG(), Accidental = new StepAccidentalFlat() };

        public static Step G => new Step { Name = new StepNameG(), Accidental = new StepAccidentalNatural() };

        public static Step GSharp => new Step { Name = new StepNameG(), Accidental = new StepAccidentalSharp() };

        public static Step Ab => new Step { Name = new StepNameA(), Accidental = new StepAccidentalFlat() };

        public static Step A => new Step { Name = new StepNameA(), Accidental = new StepAccidentalNatural() };

        public static Step ASharp => new Step { Name = new StepNameA(), Accidental = new StepAccidentalSharp() };

        public static Step Bb => new Step { Name = new StepNameB(), Accidental = new StepAccidentalFlat() };

        public static Step B => new Step { Name = new StepNameB(), Accidental = new StepAccidentalNatural() };

        public static Step BSharp => new Step { Name = new StepNameB(), Accidental = new StepAccidentalSharp() };

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

            var regexNote = new Regex("^[A-Ga-g]$");
            var regexAlter = new Regex("^[b♭#♯]$");

            string stepName = string.Empty;
            string accidental = string.Empty;

            foreach (char c in s)
            {
                if (stepName == string.Empty)
                {
                    if (regexNote.IsMatch(c.ToString()))
                    {
                        stepName += char.ToUpper(c).ToString();
                    }
                }
                else
                {
                    if (regexAlter.IsMatch(c.ToString()))
                    {
                        accidental += c.ToString();
                    }
                }
            }

            return new Step { Name = stepName, Accidental = accidental };
        }

        public static implicit operator string(Step s)
        {
            return s.Name.Name;
        }

        public static bool operator ==(Step s1, Step s2)
        {
            if (s1.Name.Name.Equals(s2.Name.Name, StringComparison.OrdinalIgnoreCase))
            {
                return s1.Accidental == s2.Accidental;
            }

            return false;
        }

        public static bool operator !=(Step s1, Step s2)
        {
            if (s1.Name.Name.Equals(s2.Name.Name, StringComparison.OrdinalIgnoreCase))
            {
                return s1.Accidental != s2.Accidental;
            }

            return true;
        }

        public static Step FromPitch(Pitch pitch)
        {
            return new Step { Name = pitch.Name, Accidental = pitch.Accidental };
        }

        public Pitch ToPitch(int octaveNumber = 4)
        {
            return Pitch.FromStep(this, octaveNumber);
        }

        public override string ToString()
        {
            return $"{Name}{Accidental.SignAscii}";
        }

        public bool Equals(Step other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Name, other.Name) && Equals(Accidental, other.Accidental);
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
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Accidental != null ? Accidental.GetHashCode() : 0);
            }
        }
    }
}