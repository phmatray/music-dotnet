using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningDroppedB : Tuning
    {
        public TuningDroppedB()
            : base("B", "G♭", "B", "E", "A♭", "D♭")
        {
        }

        public override string GetName()
        {
            return "Dropped B";
        }
    }
}