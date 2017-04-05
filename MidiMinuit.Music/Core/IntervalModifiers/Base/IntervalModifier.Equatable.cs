using System;

namespace MidiMinuit.Music.Core
{
    public partial class IntervalModifier
        : IEquatable<IntervalModifier>
    {
        public bool Equals(IntervalModifier other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((IntervalModifier) obj);
        }

        public override int GetHashCode()
        {
            return Alias.GetHashCode();
        }

        public static bool operator ==(IntervalModifier left, IntervalModifier right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IntervalModifier left, IntervalModifier right)
        {
            return !Equals(left, right);
        }
    }
}