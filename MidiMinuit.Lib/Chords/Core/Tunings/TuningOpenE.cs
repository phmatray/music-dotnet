using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenE : Tuning
    {
        public TuningOpenE()
            : base("E", "B", "E", "Ab", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Open E";
        }
    }
}