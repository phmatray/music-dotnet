using System;

namespace MidiMinuit.Music.Core.Scales
{
    public partial class Scale
        : IEquatable<Scale>
    {
        public bool Equals(Scale other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Scale) obj);
        }

        public override int GetHashCode()
        {
            return Alias.GetHashCode();
        }

        public static bool operator ==(Scale left, Scale right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Scale left, Scale right)
        {
            return !Equals(left, right);
        }
    }
}