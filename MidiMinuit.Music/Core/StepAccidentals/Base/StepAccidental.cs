namespace MidiMinuit.Music.Core
{
    public abstract partial class StepAccidental
    {
        public abstract StepAccidentalAlias Alias { get; }

        public abstract int Value { get; }

        public abstract string Name { get; }

        public abstract string SignUnicode { get; }

        public abstract string SignAscii { get; }

        public abstract override string ToString();

        public abstract StepAccidental Clone();
    }
}