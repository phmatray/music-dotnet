namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public abstract class NoteAccidental
    {
        public abstract NoteAccidentalAlias Alias { get; }

        public abstract int Value { get; }

        public abstract string Name { get; }

        public abstract string SignUnicode { get; }

        public abstract string SignAscii { get; }

        public abstract override string ToString();

        public abstract NoteAccidental Clone();
    }
}