using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningDobroOpenG : Tuning
    {
        public TuningDobroOpenG()
            : base("G", "B", "D", "G", "B", "D")
        {
        }

        public override string GetName()
        {
            return "Dobro Open G";
        }
    }
}