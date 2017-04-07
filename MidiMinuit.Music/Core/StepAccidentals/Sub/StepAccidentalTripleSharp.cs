namespace MidiMinuit.Music.Core
{
    public class StepAccidentalTripleSharp
        : StepAccidental
    {
        public override StepAccidentalAlias Alias { get; }
            = StepAccidentalAlias.TripleSharp;

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
    }
}