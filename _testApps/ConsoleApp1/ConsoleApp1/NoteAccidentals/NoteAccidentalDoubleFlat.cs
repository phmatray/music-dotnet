namespace ConsoleApp1.NoteAccidentals
{
    public class NoteAccidentalDoubleFlat
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.DoubleSharp;

        public override int Value { get; }
            = -2;

        public override string Name { get; }
            = "Double Flat";

        public override string Symbol { get; }
            = "♭♭";

        public override string Symbol2 { get; }
            = "bb";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}