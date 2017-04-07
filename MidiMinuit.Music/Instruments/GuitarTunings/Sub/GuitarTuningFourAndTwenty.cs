using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningFourAndTwenty
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.FourAndTwenty;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Four and Twenty Tuning";

        public override string Tuning { get; }
            = "D A D D A D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 50, -2, 7),
                new GuitarString(5, 57, 0, 5),
                new GuitarString(4, 62, 0, 0),
                new GuitarString(3, 62, -5, 7),
                new GuitarString(2, 69, -2, 5),
                new GuitarString(1, 74, -2)
            };
    }
}