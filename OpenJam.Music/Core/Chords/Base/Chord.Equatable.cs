using System;

namespace OpenJam.Music.Core
{
    public partial class Chord
        : IEquatable<Chord>
    {
        public bool Equals(Chord other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(Fondamental, other.Fondamental);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Chord) obj);
        }

        public override int GetHashCode()
        {
            return (Fondamental != null ? Fondamental.GetHashCode() : 0);
        }

        public static bool operator ==(Chord left, Chord right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Chord left, Chord right)
        {
            return !Equals(left, right);
        }
    }
}