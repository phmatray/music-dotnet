using System;

namespace MidiMinuit.Music.Core.StepAccidentals
{
    public partial class StepAccidental
        : IEquatable<StepAccidental>
    {
        public bool Equals(StepAccidental other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((StepAccidental) obj);
        }

        public override int GetHashCode()
        {
            return Alias.GetHashCode();
        }

        public static bool operator ==(StepAccidental left, StepAccidental right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StepAccidental left, StepAccidental right)
        {
            return !Equals(left, right);
        }
    }
}