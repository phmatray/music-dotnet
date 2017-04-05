using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningOpenA
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.OpenA;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Open;

        public override string Name { get; }
            = "The Open A Tuning";

        public override string Tuning { get; }
            = "E A C# E A E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 52, 0, 5),
                new GuitarString(5, 57, 0, 4),
                new GuitarString(4, 61, -1, 3),
                new GuitarString(3, 64, -3, 5),
                new GuitarString(2, 69, -2, 7),
                new GuitarString(1, 76, 0)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}