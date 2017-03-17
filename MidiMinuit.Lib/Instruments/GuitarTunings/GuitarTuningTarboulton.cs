namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningTarboulton
        : GuitarTuning
    {
        public override GuitarTuningType TuningType { get; }
            = GuitarTuningType.Tarboulton;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Tarboulton Tuning";

        public override string Tuning { get; }
            = "C A# C F A# F";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 48, -4, 10),
                new GuitarString(5, 58, 1, 2),
                new GuitarString(4, 60, -2, 5),
                new GuitarString(3, 65, -2, 5),
                new GuitarString(2, 70, -1, 7),
                new GuitarString(1, 77, 1)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}