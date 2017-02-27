using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenD : Tuning
    {
        public TuningOpenD()
            : base("D", "A", "D", "Gb", "A", "D")
        {
        }

        public override string GetName()
        {
            return "Open D";
        }
    }
}