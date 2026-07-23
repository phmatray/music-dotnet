using System.Collections.Generic;

namespace OpenJam.Music.Instruments
{
    public class GuitarTuningDobro
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Dobro;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Instrumental;

        public override string Name { get; }
            = "The Dobro Tuning";

        public override string Tuning { get; }
            = "G B D G B D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 55, 3, 4),
                new GuitarString(5, 59, 2, 3),
                new GuitarString(4, 62, 0, 5),
                new GuitarString(3, 67, 0, 4),
                new GuitarString(2, 71, 0, 3),
                new GuitarString(1, 74, -2)
            };
    }
}