using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningMinorThird
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.MinorThird;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Regular;

        public override string Name { get; }
            = "The Minor Third Tuning";

        public override string Tuning { get; }
            = "C D# F# A C D#";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 60, 8, 3),
                new GuitarString(5, 63, 6, 3),
                new GuitarString(4, 66, 4, 3),
                new GuitarString(3, 69, 2, 3),
                new GuitarString(2, 72, 1, 3),
                new GuitarString(1, 75, -1)
            };
    }
}