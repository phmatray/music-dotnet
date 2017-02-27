using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningTuneDownTwoStep : Tuning
    {
        public TuningTuneDownTwoStep()
            : base("C", "F", "Bb", "Eb", "G", "C")
        {
        }

        public override string GetName()
        {
            return "Tune down 2 step";
        }
    }
}