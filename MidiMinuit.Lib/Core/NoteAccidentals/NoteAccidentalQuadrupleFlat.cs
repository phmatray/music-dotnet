namespace MidiMinuit.Lib.Core.NoteAccidentals
{
    public class NoteAccidentalQuadrupleFlat
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.QuadrupleFlat;

        public override int Value { get; }
            = -4;

        public override string Name { get; }
            = "Quadruple Flat";

        public override string Symbol { get; }
            = "♭♭♭♭";

        public override string Symbol2 { get; }
            = "bbbb";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}