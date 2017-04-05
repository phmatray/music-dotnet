using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningToulouse
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Toulouse;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Toulouse Tuning";

        public override string Tuning { get; }
            = "E C D F A D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 52, 0, 8),
                new GuitarString(5, 60, 3, 2),
                new GuitarString(4, 62, 0, 3),
                new GuitarString(3, 65, -2, 4),
                new GuitarString(2, 69, -2, 5),
                new GuitarString(1, 74, -2)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}