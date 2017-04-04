namespace MidiMinuit.Music.Core.StepAccidentals
{
    public abstract partial class StepAccidental
    {
        public abstract NoteAccidentalAlias Alias { get; }

        public abstract int Value { get; }

        public abstract string Name { get; }

        public abstract string SignUnicode { get; }

        public abstract string SignAscii { get; }

        public abstract override string ToString();

        public abstract StepAccidental Clone();
    }
}