namespace ConsoleApp1.NoteAccidentals
{
    public abstract class NoteAccidental
    {
        public abstract Accidental Accidental { get; }

        public abstract int Value { get; }

        public abstract string Name { get; }

        public abstract string Symbol { get; }

        public abstract string Symbol2 { get; }

        public abstract override string ToString();

        public abstract NoteAccidental Clone();
    }
}