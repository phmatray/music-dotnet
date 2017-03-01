using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenGm : Tuning
    {
        public TuningOpenGm()
            : base("D", "G", "D", "G", "B♭", "D")
        {
        }

        public override string GetName()
        {
            return "Open Gm";
        }
    }
}