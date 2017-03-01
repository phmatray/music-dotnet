using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningBaritone : Tuning
    {
        public TuningBaritone()
            : base("B", "E", "A", "D", "G♭", "B")
        {
        }

        public override string GetName()
        {
            return "Baritone";
        }
    }
}