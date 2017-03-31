namespace MidiMinuit.Music.Core.NoteAccidentals
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

        public override string SignUnicode { get; }
            = "♯";

        public override string SignAscii { get; }
            = "#";

        public override string ToString()
            => SignUnicode;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}