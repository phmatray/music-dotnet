namespace MidiMinuit.Lib.NoteAccidentals
{
    public class NoteAccidentalDoubleSharp
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.DoubleSharp;

        public override int Value { get; }
            = 2;

        public override string Name { get; }
            = "Double Sharp";

        public override string Symbol { get; }
            = "♯♯";

        public override string Symbol2 { get; }
            = "##";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}