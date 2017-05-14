namespace MidiMinuit.Lib.NoteAccidentals
{
    public class NoteAccidentalNatural
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.Natural;

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