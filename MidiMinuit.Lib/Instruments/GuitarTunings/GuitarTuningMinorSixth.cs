namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningMinorSixth
        : GuitarTuning
    {
        public override GuitarTuningType TuningType { get; }
            = GuitarTuningType.MinorSixth;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Regular;

        public override string Name { get; }
            = "The Minor Sixth Tuning";

        public override string Tuning { get; }
            = "C G# E C G# E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 36, -16, 8),
                new GuitarString(5, 44, -13, 8),
                new GuitarString(4, 52, -10, 8),
                new GuitarString(3, 60, -7, 8),
                new GuitarString(2, 68, -3, 8),
                new GuitarString(1, 76, 0)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}