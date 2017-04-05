using System;

namespace MidiMinuit.Music.Core
{
    public partial class Pitch
        : IEquatable<Pitch>
    {
        public bool Equals(Pitch other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return base.Equals(other) && MidiPitch == other.MidiPitch && Octave == other.Octave;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Pitch) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ MidiPitch;
                hashCode = (hashCode * 397) ^ Octave;
                return hashCode;
            }
        }

        public static bool operator ==(Pitch left, Pitch right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Pitch left, Pitch right)
        {
            return !Equals(left, right);
        }
    }
}