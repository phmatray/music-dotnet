using System;

namespace MidiMinuit.Music.Core.Intervals
{
    public partial class Interval
        : IEquatable<Interval>
    {
        public bool Equals(Interval other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(_lowerPitch, other._lowerPitch) && Equals(UpperPitch, other.UpperPitch);
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
                return ((_lowerPitch != null ? _lowerPitch.GetHashCode() : 0) * 397) ^ (UpperPitch != null ? UpperPitch.GetHashCode() : 0);
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