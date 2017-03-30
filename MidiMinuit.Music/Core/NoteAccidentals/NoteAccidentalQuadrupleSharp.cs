namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class NoteAccidentalQuadrupleSharp
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.QuadrupleSharp;

        public override int Value { get; }
            = 4;

        public override string Name { get; }
            = "Quadruple Sharp";

        public override string Symbol { get; }
            = "♯♯♯♯";

        public override string Symbol2 { get; }
            = "####";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}