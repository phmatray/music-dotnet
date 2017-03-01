using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningDroppedE : Tuning
    {
        public TuningDroppedE()
            : base("E", "B", "E", "A", "D♭", "G♭")
        {
        }

        public override string GetName()
        {
            return "Dropped E";
        }
    }
}