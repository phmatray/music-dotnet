using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenD6 : Tuning
    {
        public TuningOpenD6()
            : base("D", "A", "D", "G♭", "B", "D")
        {
        }

        public override string GetName()
        {
            return "Open D6";
        }
    }
}