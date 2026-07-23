namespace OpenJam.Music.Core
{
    public partial class StepAccidental
    {
        public static StepAccidentalNatural Natural
            => new StepAccidentalNatural();

        public static StepAccidentalFlat Flat
            => new StepAccidentalFlat();

        public static StepAccidentalSharp Sharp
            => new StepAccidentalSharp();

        public static StepAccidentalDoubleFlat DoubleFlat
            => new StepAccidentalDoubleFlat();

        public static StepAccidentalDoubleSharp DoubleSharp
            => new StepAccidentalDoubleSharp();

        public static StepAccidentalTripleFlat TripleFlat
            => new StepAccidentalTripleFlat();

        public static StepAccidentalTripleSharp TripleSharp
            => new StepAccidentalTripleSharp();

        public static StepAccidentalQuadrupleFlat QuadrupleFlat
            => new StepAccidentalQuadrupleFlat();

        public static StepAccidentalQuadrupleSharp QuadrupleSharp
            => new StepAccidentalQuadrupleSharp();
    }
}