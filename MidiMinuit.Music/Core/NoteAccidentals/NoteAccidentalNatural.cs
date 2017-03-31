namespace MidiMinuit.Music.Core.NoteAccidentals
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

        public override string SignUnicode { get; }
            = "";

        public override string SignAscii { get; }
            = "";

        public override string ToString()
            => SignUnicode;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}