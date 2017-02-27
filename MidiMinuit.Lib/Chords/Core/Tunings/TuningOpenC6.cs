using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenC6 : Tuning
    {
        public TuningOpenC6()
            : base("C", "G", "C", "G", "A", "E")
        {
        }

        public override string GetName()
        {
            return "Open C6";
        }
    }
}