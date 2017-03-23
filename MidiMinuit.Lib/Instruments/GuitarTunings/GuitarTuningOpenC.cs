namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningOpenC
        : GuitarTuning
    {
        public override GuitarTuningAlias Alias { get; }
            = GuitarTuningAlias.OpenC;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Open;

        public override string Name { get; }
            = "The Open C Tuning";

        public override string Tuning { get; }
            = "C G C G C E";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 48, -4, 7),
                new GuitarString(5, 55, -2, 5),
                new GuitarString(4, 60, -2, 7),
                new GuitarString(3, 67, 0, 5),
                new GuitarString(2, 72, 1, 4),
                new GuitarString(1, 76, 0)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}