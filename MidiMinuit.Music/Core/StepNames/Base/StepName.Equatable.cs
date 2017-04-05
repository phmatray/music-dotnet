using System;

namespace MidiMinuit.Music.Core.StepNames
{
    public partial class StepName
        : IEquatable<StepName>
    {
        public bool Equals(StepName other)
        {
            return GetHashCode().Equals(other.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((StepName)obj);
        }

        public override int GetHashCode()
        {
            return Alias.GetHashCode();
        }

        public static bool operator ==(StepName left, StepName right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StepName left, StepName right)
        {
            return !Equals(left, right);
        }
    }
}