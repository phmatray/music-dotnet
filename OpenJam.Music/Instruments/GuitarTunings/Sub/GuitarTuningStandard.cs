using System.Collections.Generic;

namespace OpenJam.Music.Instruments
{
    public class GuitarTuningStandard
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Standard;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Standard;

        public override string Name { get; }
            = "Standard";

        public override string Tuning { get; }
            = "E A D G B E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 52, 0, 5),
                new GuitarString(5, 57, 0, 5),
                new GuitarString(4, 62, 0, 5),
                new GuitarString(3, 67, 0, 4),
                new GuitarString(2, 71, 0, 5),
                new GuitarString(1, 76, 0)
            };
    }
}