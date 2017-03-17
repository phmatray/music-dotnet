namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    using System.Collections.Generic;

    public class GuitarTuningOpenD
        : GuitarTuning
    {
        public override GuitarTuningType TuningType { get; }
            = GuitarTuningType.OpenD;

        public override GuitarTuningCategory Category { get; }
            = GuitarTuningCategory.Open;

        public override string Name { get; }
            = "The Open D Tuning";

        public override string Tuning { get; }
            = "D A D F# A D";

        public override string Description { get; }
            = "";

        public override List<GuitarString> Strings { get; }
            = new List<GuitarString>
            {
                new GuitarString(6, 50, -2, 7),
                new GuitarString(5, 57, 0, 5),
                new GuitarString(4, 62, 0, 4),
                new GuitarString(3, 66, -1, 3),
                new GuitarString(2, 69, -2, 5),
                new GuitarString(1, 74, -2)
            };

        public override GuitarTuning Clone()
            => MemberwiseClone() as GuitarTuning;
    }
}