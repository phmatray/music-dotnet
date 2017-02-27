using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenDsus4 : Tuning
    {
        public TuningOpenDsus4()
            : base("D", "A", "D", "G", "A", "D")
        {
        }

        public override string GetName()
        {
            return "Open Dsus4";
        }
    }
}