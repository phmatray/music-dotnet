namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class NoteAccidentalTripleFlat
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.TripleFlat;

        public override int Value { get; }
            = -3;

        public override string Name { get; }
            = "Triple Flat";

        public override string Symbol { get; }
            = "♭♭♭";

        public override string Symbol2 { get; }
            = "bbb";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}