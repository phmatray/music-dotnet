namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningMajorSixth
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.MajorSixth;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Regular;

        public override string Name { get; }
            = "The Major Sixth Tuning";

        public override string Tuning { get; }
            = "C A F# D# C A";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 36, -16, 9),
                new GuitarString(5, 45, -12, 9),
                new GuitarString(4, 54, -8, 9),
                new GuitarString(3, 63, -4, 9),
                new GuitarString(2, 72, 1, 9),
                new GuitarString(1, 81, 5)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}