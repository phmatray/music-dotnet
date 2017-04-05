namespace MidiMinuit.Music.Core
{
    public abstract partial class Degree
    {
        public abstract DegreeAlias Alias { get; }

        public abstract string DiatonicFunction { get; }

        public abstract string CorrespondingModeMajorKey { get; }

        public abstract string CorrespondingModeMinorKey { get; }

        public abstract string Meaning { get; }

        public abstract string Function { get; }

        public abstract Pitch PitchInCMajor { get; }

        public abstract Pitch PitchInCMinor { get; }

        public int DegreeIndex
            => (int)Alias - 1;

        public abstract override string ToString();

        public abstract Degree Clone();
    }
}