using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments.GuitarTunings
{
    public class GuitarTuningSlowMotion
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.SlowMotion;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Slow Motion Tuning";

        public override string Tuning { get; }
            = "D G D F C D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 50, -2, 5),
                new GuitarString(5, 55, -2, 7),
                new GuitarString(4, 62, 0, 3),
                new GuitarString(3, 65, -2, 7),
                new GuitarString(2, 72, 1, 2),
                new GuitarString(1, 74, -2)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}