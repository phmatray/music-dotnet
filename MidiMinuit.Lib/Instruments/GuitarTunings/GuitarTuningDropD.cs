namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningDropD
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.DropD;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Special;

        public override string Name { get; }
            = "The Drop D Tuning";

        public override string Tuning { get; }
            = "D A D G B E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 50, -2, 7),
                new GuitarString(5, 57, 0, 5),
                new GuitarString(4, 62, 0, 5),
                new GuitarString(3, 67, 0, 4),
                new GuitarString(2, 71, 0, 5),
                new GuitarString(1, 76, 0)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}