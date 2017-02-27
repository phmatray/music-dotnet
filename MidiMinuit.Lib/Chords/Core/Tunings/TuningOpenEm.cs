using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenEm : Tuning
    {
        public TuningOpenEm()
            : base("E", "B", "E", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Open Em";
        }
    }
}