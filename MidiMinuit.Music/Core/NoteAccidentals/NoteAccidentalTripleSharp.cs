namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class NoteAccidentalTripleSharp
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.TripleSharp;

        public override int Value { get; }
            = 3;

        public override string Name { get; }
            = "Triple Sharp";

        public override string Symbol { get; }
            = "♯♯♯";

        public override string Symbol2 { get; }
            = "###";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}