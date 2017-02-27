using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningDroppedDVariant : Tuning
    {
        public TuningDroppedDVariant()
            : base("D", "A", "D", "G", "A", "E")
        {
        }

        public override string GetName()
        {
            return "Dropped D Variant";
        }
    }
}