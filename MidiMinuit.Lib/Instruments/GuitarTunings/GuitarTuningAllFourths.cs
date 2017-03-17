namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningAllFourths
        : GuitarTuning
    {
        public override GuitarTuningType TuningType { get; }
            = GuitarTuningType.AllFourths;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Regular;

        public override string Name { get; }
            = "The All Fourths Tuning";

        public override string Tuning { get; }
            = "E A D G C F";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 52, 0, 5),
                new GuitarString(5, 57, 0, 5),
                new GuitarString(4, 62, 0, 5),
                new GuitarString(3, 67, 0, 5),
                new GuitarString(2, 72, 1, 5),
                new GuitarString(1, 77, 1)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}