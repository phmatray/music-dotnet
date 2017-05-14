using System;

namespace OpenJam.Music.Core
{
    public partial class Interval
        : IEquatable<Interval>
    {
        public bool Equals(Interval other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(_startingPitch, other._startingPitch) && Equals(EndingPitch, other.EndingPitch);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Interval) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_startingPitch != null ? _startingPitch.GetHashCode() : 0) * 397) ^ (EndingPitch != null ? EndingPitch.GetHashCode() : 0);
            }
        }

        public static bool operator ==(Interval left, Interval right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Interval left, Interval right)
        {
            return !Equals(left, right);
        }
    }
}