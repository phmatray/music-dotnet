using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningOpenEsus11 : Tuning
    {
        public TuningOpenEsus11()
            : base("E", "A", "E", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Open Esus11";
        }
    }
}