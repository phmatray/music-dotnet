namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class StepAccidentalTripleSharp
        : StepAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.TripleSharp;

        public override int Value { get; }
            = 3;

        public override string Name { get; }
            = "Triple Sharp";

        public override string SignUnicode { get; }
            = "♯♯♯";

        public override string SignAscii { get; }
            = "###";

        public override string ToString()
            => SignUnicode;

        public override StepAccidental Clone()
            => MemberwiseClone() as StepAccidental;
    }
}