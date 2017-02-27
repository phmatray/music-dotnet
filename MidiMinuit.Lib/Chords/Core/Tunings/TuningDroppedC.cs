using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningDroppedC : Tuning
    {
        public TuningDroppedC()
            : base("C", "G", "C", "F", "A", "D")
        {
        }

        public override string GetName()
        {
            return "Dropped C";
        }
    }
}