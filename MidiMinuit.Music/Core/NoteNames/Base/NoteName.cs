namespace MidiMinuit.Music.Core.NoteNames
{
    public abstract class NoteName
    {
        public abstract NoteNameAlias Alias { get; }

        public abstract int Value { get; }

        public abstract int Order { get; }

        public abstract string Name { get; }

        public abstract string NameLatin { get; }

        public abstract override string ToString();

        public abstract NoteName Clone();
    }
}
