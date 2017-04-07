using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningMandoguitar
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Mandoguitar;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Regular;

        public override string Name { get; }
            = "The Mandoguitar Tuning";

        public override string Tuning { get; }
            = "C G D A E B";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 48, -4, 7),
                new GuitarString(5, 55, -2, 7),
                new GuitarString(4, 62, 0, 7),
                new GuitarString(3, 69, 2, 7),
                new GuitarString(2, 76, 5, 7),
                new GuitarString(1, 83, 7)
            };
    }
}