using System;

namespace MidiMinuit.Music.Core
{
    public partial class Degree
        : IEquatable<Degree>
    {
        public bool Equals(Degree other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Degree) obj);
        }

        public override int GetHashCode()
        {
            return Alias.GetHashCode();
        }

        public static bool operator ==(Degree left, Degree right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Degree left, Degree right)
        {
            return !Equals(left, right);
        }
    }
}