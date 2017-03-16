namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningTuneDownTwoStep : GuitarTuning
    {
        public TuningTuneDownTwoStep()
            : base("C", "F", "B♭", "E♭", "G", "C")
        {
        }

        public override string GetName()
        {
            return "Tune down 2 step";
        }
    }
}