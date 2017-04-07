namespace MidiMinuit.Music.Core
{
    public abstract partial class StepName
    {
        public abstract StepNameAlias Alias { get; }

        public abstract int Semitones { get; }

        public abstract int MidiPitch { get; }

        public abstract int StepNumber { get; }

        public abstract string Name { get; }

        public abstract string NameLatin { get; }

        public abstract override string ToString();
    }
}
