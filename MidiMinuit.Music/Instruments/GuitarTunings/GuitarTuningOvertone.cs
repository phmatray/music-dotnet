using System.Collections.Generic;

namespace MidiMinuit.Music.Instruments.GuitarTunings
{
    public class GuitarTuningOvertone
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Overtone;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Instrumental;

        public override string Name { get; }
            = "The Overtone Tuning";

        public override string Tuning { get; }
            = "C E G A# C D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 60, 8, 4),
                new GuitarString(5, 64, 7, 3),
                new GuitarString(4, 67, 5, 3),
                new GuitarString(3, 70, 3, 2),
                new GuitarString(2, 72, 1, 2),
                new GuitarString(1, 74, -2)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}