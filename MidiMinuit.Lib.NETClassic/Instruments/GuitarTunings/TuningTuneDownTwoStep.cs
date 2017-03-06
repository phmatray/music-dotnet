namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningTuneDownTwoStep : Tuning
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