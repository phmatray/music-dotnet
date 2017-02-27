using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningDroppedD : Tuning
    {
        public TuningDroppedD()
            : base("D", "A", "D", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Dropped D";
        }
    }
}