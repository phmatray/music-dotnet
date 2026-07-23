using System.Collections.Generic;

namespace OpenJam.Music.Instruments
{
    public class GuitarTuningPelican
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Pelican;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Pelican Tuning";

        public override string Tuning { get; }
            = "D A D E A D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 50, -2, 7),
                new GuitarString(5, 57, 0, 5),
                new GuitarString(4, 62, 0, 2),
                new GuitarString(3, 64, -3, 5),
                new GuitarString(2, 69, -2, 5),
                new GuitarString(1, 74, -2)
            };
    }
}