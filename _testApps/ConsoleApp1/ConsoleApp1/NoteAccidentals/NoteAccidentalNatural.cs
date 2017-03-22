namespace ConsoleApp1.NoteAccidentals
{
    public class NoteAccidentalNatural
        : NoteAccidental
    {
        public override Accidental Accidental { get; }
            = Accidental.Natural;

        public override int Value { get; }
            = 0;

        public override string Name { get; }
            = "Natural";

        public override string Symbol { get; }
            = "";

        public override string Symbol2 { get; }
            = "";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}