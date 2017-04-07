using System;

namespace MidiMinuit.Music.Core
{
    public partial class DiatonicInterval
        : IEquatable<DiatonicInterval>
    {
        public bool Equals(DiatonicInterval other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((DiatonicInterval) obj);
        }

        public override int GetHashCode()
        {
            return DiatonicIntervalAlias.GetHashCode();
        }

        public static bool operator ==(DiatonicInterval left, DiatonicInterval right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DiatonicInterval left, DiatonicInterval right)
        {
            return !Equals(left, right);
        }
    }
}