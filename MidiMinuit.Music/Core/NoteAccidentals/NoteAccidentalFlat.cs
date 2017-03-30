namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class NoteAccidentalFlat
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.Flat;

        public override int Value { get; }
            = -1;

        public override string Name { get; }
            = "Flat";

        public override string Symbol { get; }
            = "♭";

        public override string Symbol2 { get; }
            = "b";

        public override string ToString()
            => Symbol;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}