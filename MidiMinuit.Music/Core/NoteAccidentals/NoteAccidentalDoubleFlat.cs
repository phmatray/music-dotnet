namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class NoteAccidentalDoubleFlat
        : NoteAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.DoubleFlat;

        public override int Value { get; }
            = -2;

        public override string Name { get; }
            = "Double Flat";

        public override string SignUnicode { get; }
            = "♭♭";

        public override string SignAscii { get; }
            = "bb";

        public override string ToString()
            => SignUnicode;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}