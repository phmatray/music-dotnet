namespace MidiMinuit.Music.Core
{
    public class StepAccidentalQuadrupleFlat
        : StepAccidental
    {
        public override StepAccidentalAlias Alias { get; }
            = StepAccidentalAlias.QuadrupleFlat;

        public override int Value { get; }
            = -4;

        public override string Name { get; }
            = "Quadruple Flat";

        public override string SignUnicode { get; }
            = "♭♭♭♭";

        public override string SignAscii { get; }
            = "bbbb";

        public override string ToString()
            => SignUnicode;

        public override StepAccidental Clone()
            => MemberwiseClone() as StepAccidental;
    }
}