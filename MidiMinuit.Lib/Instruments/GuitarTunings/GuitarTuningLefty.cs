namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningLefty
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.Lefty;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Instrumental;

        public override string Name { get; }
            = "The Lefty Tuning";

        public override string Tuning { get; }
            = "E B G D A E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 76, 24, -5),
                new GuitarString(5, 71, 14, -4),
                new GuitarString(4, 67, 5, -5),
                new GuitarString(3, 62, -5, -5),
                new GuitarString(2, 57, -14, -5),
                new GuitarString(1, 52, -24)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}