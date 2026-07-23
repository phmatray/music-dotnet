using System.Collections.Generic;

namespace OpenJam.Music.Instruments
{
    public class GuitarTuningBalalaika
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Balalaika;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Instrumental;

        public override string Name { get; }
            = "The Balalaika Tuning";

        public override string Tuning { get; }
            = "E A D E E A";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 52, 0, 5),
                new GuitarString(5, 57, 0, 5),
                new GuitarString(4, 62, 0, 2),
                new GuitarString(3, 64, -3, 0),
                new GuitarString(2, 64, -7, 5),
                new GuitarString(1, 69, -7)
            };
    }
}