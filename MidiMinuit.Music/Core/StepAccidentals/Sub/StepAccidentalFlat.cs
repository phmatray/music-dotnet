namespace MidiMinuit.Music.Core
{
    public class StepAccidentalFlat
        : StepAccidental
    {
        public override StepAccidentalAlias Alias { get; }
            = StepAccidentalAlias.Flat;

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

        public override StepAccidental Clone()
            => MemberwiseClone() as StepAccidental;
    }
}