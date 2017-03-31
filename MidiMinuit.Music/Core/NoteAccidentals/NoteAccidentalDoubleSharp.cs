namespace MidiMinuit.Music.Core.NoteAccidentals
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

        public override string SignUnicode { get; }
            = "♯♯";

        public override string SignAscii { get; }
            = "##";

        public override string ToString()
            => SignUnicode;

        public override NoteAccidental Clone()
            => MemberwiseClone() as NoteAccidental;
    }
}