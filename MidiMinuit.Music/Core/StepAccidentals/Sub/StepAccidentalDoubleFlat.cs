namespace MidiMinuit.Music.Core
{
    public class StepAccidentalDoubleFlat
        : StepAccidental
    {
        public override StepAccidentalAlias Alias { get; }
            = StepAccidentalAlias.DoubleFlat;

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
    }
}