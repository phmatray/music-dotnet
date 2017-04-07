using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningFace
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Face;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Face Tuning";

        public override string Tuning { get; }
            = "C G D G A D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 48, -4, 7),
                new GuitarString(5, 55, -2, 7),
                new GuitarString(4, 62, 0, 5),
                new GuitarString(3, 67, 0, 2),
                new GuitarString(2, 69, -2, 5),
                new GuitarString(1, 74, -2)
            };
    }
}