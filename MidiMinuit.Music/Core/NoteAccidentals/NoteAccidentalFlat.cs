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

        public override string SignUnicode { get; }
            = "♭";

        public override string SignAscii { get; }
            = "b";

        public override string ToString()
            => SignUnicode;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}