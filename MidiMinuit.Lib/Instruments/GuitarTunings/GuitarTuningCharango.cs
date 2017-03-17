namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningCharango
        : GuitarTuning
    {
        public override GuitarTuningType TuningType { get; }
            = GuitarTuningType.Charango;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Instrumental;

        public override string Name { get; }
            = "The Charango Tuning";

        public override string Tuning { get; }
            = "X G C E A E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6),
                new GuitarString(5, 55, -2, 5),
                new GuitarString(4, 60, -2, -8),
                new GuitarString(3, 52, -15, 5),
                new GuitarString(2, 57, -14, 7),
                new GuitarString(1, 64, -12)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}