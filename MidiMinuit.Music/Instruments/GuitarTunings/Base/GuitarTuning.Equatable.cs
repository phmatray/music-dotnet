using System;

namespace MidiMinuit.Music.Instruments
{
    public partial class GuitarTuning
        : IEquatable<GuitarTuning>
    {
        public bool Equals(GuitarTuning other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((GuitarTuning) obj);
        }

        public override int GetHashCode()
        {
            return Alias.GetHashCode();
        }

        public static bool operator ==(GuitarTuning left, GuitarTuning right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GuitarTuning left, GuitarTuning right)
        {
            return !Equals(left, right);
        }
    }
}