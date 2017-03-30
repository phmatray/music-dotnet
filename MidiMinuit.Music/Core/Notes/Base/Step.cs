using System;
using System.Linq;
using System.Text;

namespace MidiMinuit.Music.Core.Notes
{
    public class Step : IEquatable<Step>
    {
        public string StepName { get; set; }

        public int Alter { get; set; }

        public static Step Cb => new Step { StepName = "C", Alter = -1 };

        public static Step C => new Step { StepName = "C", Alter = 0 };

        public static Step CSharp => new Step { StepName = "C", Alter = 1 };

        public static Step Db => new Step { StepName = "D", Alter = -1 };

        public static Step D => new Step { StepName = "D", Alter = 0 };

        public static Step DSharp => new Step { StepName = "D", Alter = 1 };

        public static Step Eb => new Step { StepName = "E", Alter = -1 };

        public static Step E => new Step { StepName = "E", Alter = 0 };

        public static Step ESharp => new Step { StepName = "E", Alter = 1 };

        public static Step Fb => new Step { StepName = "F", Alter = -1 };

        public static Step F => new Step { StepName = "F", Alter = 0 };

        public static Step FSharp => new Step { StepName = "F", Alter = 1 };

        public static Step Gb => new Step { StepName = "G", Alter = -1 };

        public static Step G => new Step { StepName = "G", Alter = 0 };

        public static Step GSharp => new Step { StepName = "G", Alter = 1 };

        public static Step Ab => new Step { StepName = "A", Alter = -1 };

        public static Step A => new Step { StepName = "A", Alter = 0 };

        public static Step ASharp => new Step { StepName = "A", Alter = 1 };

        public static Step Bb => new Step { StepName = "B", Alter = -1 };

        public static Step B => new Step { StepName = "B", Alter = 0 };

        public static Step BSharp => new Step { StepName = "B", Alter = 1 };

        protected Step()
        {
        }

        public static implicit operator Step(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            var stepNames = new[] { "A", "B", "C", "D", "E", "F", "G" };
            if (!stepNames.Contains(s.ToUpper()))
            {
                throw new InvalidCastException($"{s} is not a valid step name.");
            }

            return new Step { StepName = s, Alter = 0 };
        }

        public static implicit operator string(Step s)
        {
            return s.StepName;
        }

        public static bool operator ==(Step s1, Step s2)
        {
            if (s1.StepName.Equals(s2.StepName, StringComparison.OrdinalIgnoreCase))
            {
                return s1.Alter == s2.Alter;
            }

            return false;
        }

        public static bool operator !=(Step s1, Step s2)
        {
            if (s1.StepName.Equals(s2.StepName, StringComparison.OrdinalIgnoreCase))
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
            return $"{StepName}{AlterToSigns(Alter)}";
        }

        protected static string AlterToSigns(int alter)
        {
            var stringBuilder = new StringBuilder();
            for (var index = 0; index < Math.Abs(alter); ++index)
            {
                stringBuilder.Append(alter < 0 ? "b" : "#");
            }

            return stringBuilder.ToString();
        }

        public int ToStepNumber()
        {
            switch (StepName)
            {
                case "C":
                    return 1;
                case "D":
                    return 2;
                case "E":
                    return 3;
                case "F":
                    return 4;
                case "G":
                    return 5;
                case "A":
                    return 6;
                case "B":
                    return 7;
                default:
                    return 0;
            }
        }

        public bool Equals(Step other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(StepName, other.StepName) && Alter == other.Alter;
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
                return ((StepName != null ? StepName.GetHashCode() : 0) * 397) ^ Alter;
            }
        }
    }
}