namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public abstract class NoteAccidental
    {
        public abstract NoteAccidentalAlias Alias { get; }

        public abstract int Value { get; }

        public abstract string Name { get; }

        public abstract string Symbol { get; }

        public abstract string Symbol2 { get; }

        public abstract override string ToString();

        public abstract NoteAccidental Clone();
    }
}