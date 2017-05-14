namespace OpenJam.Music.Core
{
    public class StepAccidentalSharp
        : StepAccidental
    {
        public override StepAccidentalAlias Alias { get; }
            = StepAccidentalAlias.Sharp;

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
    }
}