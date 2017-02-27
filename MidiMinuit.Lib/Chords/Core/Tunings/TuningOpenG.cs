using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenG : Tuning
    {
        public TuningOpenG()
            : base("D", "G", "D", "G", "B", "D")
        {
        }

        public override string GetName()
        {
            return "Open G";
        }
    }
}