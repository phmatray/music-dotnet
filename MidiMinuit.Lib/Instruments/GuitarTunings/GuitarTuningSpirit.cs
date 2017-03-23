namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningSpirit
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Spirit;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Spirit Tuning";

        public override string Tuning { get; }
            = "C# A C# G# A E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 49, -3, 8),
                new GuitarString(5, 57, 0, 4),
                new GuitarString(4, 61, -1, 7),
                new GuitarString(3, 68, 1, 1),
                new GuitarString(2, 69, -2, 7),
                new GuitarString(1, 76, 0)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}