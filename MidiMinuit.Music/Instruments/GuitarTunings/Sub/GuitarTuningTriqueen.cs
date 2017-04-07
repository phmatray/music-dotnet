using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningTriqueen
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Triqueen;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Triqueen Tuning";

        public override string Tuning { get; }
            = "D G D F# A B";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 50, -2, 5),
                new GuitarString(5, 55, -2, 7),
                new GuitarString(4, 62, 0, 4),
                new GuitarString(3, 66, -1, 3),
                new GuitarString(2, 69, -2, 2),
                new GuitarString(1, 71, -5)
            };
    }
}