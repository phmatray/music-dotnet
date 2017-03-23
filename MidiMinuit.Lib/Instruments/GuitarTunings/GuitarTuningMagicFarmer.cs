namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningMagicFarmer
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.MagicFarmer;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Magic Farmer Tuning";

        public override string Tuning { get; }
            = "C F C G A E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 48, -4, 5),
                new GuitarString(5, 53, -4, 7),
                new GuitarString(4, 60, -2, 7),
                new GuitarString(3, 67, 0, 2),
                new GuitarString(2, 69, -2, 7),
                new GuitarString(1, 76, 0)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}