namespace OpenJam.Music.Core
{
    public class StepAccidentalTripleFlat
        : StepAccidental
    {
        public override StepAccidentalAlias Alias { get; }
            = StepAccidentalAlias.TripleFlat;

        public override int Value { get; }
            = -3;

        public override string Name { get; }
            = "Triple Flat";

        public override string SignUnicode { get; }
            = "♭♭♭";

        public override string SignAscii { get; }
            = "bbb";

        public override string ToString()
            => SignUnicode;
    }
}