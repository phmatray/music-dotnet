namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningHotType
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.HotType;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Hot Type Tuning";

        public override string Tuning { get; }
            = "A B E F# A D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 45, -7, 14),
                new GuitarString(5, 59, 2, 5),
                new GuitarString(4, 64, 2, 2),
                new GuitarString(3, 66, -1, 3),
                new GuitarString(2, 69, -2, 5),
                new GuitarString(1, 74, -2)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}