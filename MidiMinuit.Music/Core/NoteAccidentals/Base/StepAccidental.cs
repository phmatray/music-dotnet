namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public abstract class StepAccidental
    {
        public static implicit operator StepAccidental(NoteAccidentalAlias alias)
        {
            var repo = new NoteAccidentalRepository();
            var accidental = repo.Get(alias);
            return accidental;
        }

        public static implicit operator NoteAccidentalAlias(StepAccidental accidental)
        {
            return accidental.Alias;
        }

        public abstract NoteAccidentalAlias Alias { get; }

        public abstract int Value { get; }

        public abstract string Name { get; }

        public abstract string SignUnicode { get; }

        public abstract string SignAscii { get; }

        public abstract override string ToString();

        public abstract StepAccidental Clone();
    }
}