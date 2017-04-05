using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningAugFourths
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.AugFourths;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Regular;

        public override string Name { get; }
            = "The Augmented Fourths Tuning";

        public override string Tuning { get; }
            = "C F# C F# C F#";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 48, -4, 6),
                new GuitarString(5, 54, -3, 6),
                new GuitarString(4, 60, -2, 6),
                new GuitarString(3, 66, -1, 6),
                new GuitarString(2, 72, 1, 6),
                new GuitarString(1, 78, 2)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}