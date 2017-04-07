using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningLayover
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Layover;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Layover Tuning";

        public override string Tuning { get; }
            = "D A C G C E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 50, -2, 7),
                new GuitarString(5, 57, 0, 3),
                new GuitarString(4, 60, -2, 7),
                new GuitarString(3, 67, 0, 5),
                new GuitarString(2, 72, 1, 4),
                new GuitarString(1, 76, 0)
            };
    }
}