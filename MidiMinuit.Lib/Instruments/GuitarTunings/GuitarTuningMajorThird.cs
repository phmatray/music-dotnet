namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningMajorThird
        : GuitarTuning
    {
        public override GuitarTuningType TuningType { get; }
            = GuitarTuningType.MajorThird;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Regular;

        public override string Name { get; }
            = "The Major Third Tuning";

        public override string Tuning { get; }
            = "C E G# C E G#";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 60, 8, 4),
                new GuitarString(5, 64, 7, 4),
                new GuitarString(4, 68, 6, 4),
                new GuitarString(3, 72, 5, 4),
                new GuitarString(2, 76, 5, 4),
                new GuitarString(1, 80, 4)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}