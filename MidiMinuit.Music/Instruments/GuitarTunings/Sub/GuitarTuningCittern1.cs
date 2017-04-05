using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningCittern1
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Cittern1;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Instrumental;

        public override string Name { get; }
            = "Cittern Tuning One";

        public override string Tuning { get; }
            = "C F C G C D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 48, -4, 5),
                new GuitarString(5, 53, -4, 7),
                new GuitarString(4, 60, -2, 7),
                new GuitarString(3, 67, 0, 5),
                new GuitarString(2, 72, 1, 2),
                new GuitarString(1, 74, -2)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}