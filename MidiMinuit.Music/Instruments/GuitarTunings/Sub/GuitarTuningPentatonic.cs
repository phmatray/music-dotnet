using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments
{
    public class GuitarTuningPentatonic
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Pentatonic;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Instrumental;

        public override string Name { get; }
            = "The Pentatonic Tuning";

        public override string Tuning { get; }
            = "A C D E G A";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 57, 5, 3),
                new GuitarString(5, 60, 3, 2),
                new GuitarString(4, 62, 0, 2),
                new GuitarString(3, 64, -3, 3),
                new GuitarString(2, 67, -4, 2),
                new GuitarString(1, 69, -7)
            };
    }
}