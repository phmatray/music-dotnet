using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningDoubleDroppedD : Tuning
    {
        public TuningDoubleDroppedD()
            : base("D", "A", "D", "G", "B", "D")
        {
        }

        public override string GetName()
        {
            return "Double Dropped D";
        }
    }
}