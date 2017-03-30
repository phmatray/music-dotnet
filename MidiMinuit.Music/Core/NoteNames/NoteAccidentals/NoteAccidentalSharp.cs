namespace MidiMinuit.Lib.NoteAccidentals
{
    public class NoteAccidentalSharp
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.Sharp;

        public override int Value { get; }
            = 1;

        public override string Name { get; }
            = "Sharp";

        public override string Symbol { get; }
            = "♯";

        public override string Symbol2 { get; }
            = "#";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}