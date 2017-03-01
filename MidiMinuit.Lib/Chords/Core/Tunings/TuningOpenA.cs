using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenA : Tuning
    {
        public TuningOpenA()
            : base("E", "A", "E", "A", "D♭", "E")
        {
        }

        public override string GetName()
        {
            return "Open A";
        }
    }
}