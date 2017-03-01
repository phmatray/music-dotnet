using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenCm : Tuning
    {
        public TuningOpenCm()
            : base("C", "G", "C", "G", "C", "E♭")
        {
        }

        public override string GetName()
        {
            return "Open Cm";
        }
    }
}