using System;

namespace MidiMinuit.Music.Core
{
    public partial class IntervalStep
        : IEquatable<IntervalStep>
    {
        public bool Equals(IntervalStep other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((IntervalStep) obj);
        }

        public override int GetHashCode()
        {
            return Alias.GetHashCode();
        }

        public static bool operator ==(IntervalStep left, IntervalStep right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IntervalStep left, IntervalStep right)
        {
            return !Equals(left, right);
        }
    }
}