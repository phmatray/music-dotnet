using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments.GuitarTunings
{
    public class GuitarTuningOpenGMinor
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.OpenGMinor;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Open;

        public override string Name { get; }
            = "The Open G Minor Tuning";

        public override string Tuning { get; }
            = "D G D G A# D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 50, -2, 5),
                new GuitarString(5, 55, -2, 7),
                new GuitarString(4, 62, 0, 5),
                new GuitarString(3, 67, 0, 3),
                new GuitarString(2, 70, -1, 4),
                new GuitarString(1, 74, -2)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}