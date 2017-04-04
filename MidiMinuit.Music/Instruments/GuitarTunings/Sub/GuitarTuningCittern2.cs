using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments.GuitarTunings
{
    public class GuitarTuningCittern2
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Cittern2;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Instrumental;

        public override string Name { get; }
            = "Cittern Tuning Two";

        public override string Tuning { get; }
            = "C G C G C G";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 48, -4, 7),
                new GuitarString(5, 55, -2, 5),
                new GuitarString(4, 60, -2, 7),
                new GuitarString(3, 67, 0, 5),
                new GuitarString(2, 72, 1, 7),
                new GuitarString(1, 79, 3)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}