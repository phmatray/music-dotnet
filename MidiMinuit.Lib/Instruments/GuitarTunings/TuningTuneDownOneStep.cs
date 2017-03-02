namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningTuneDownOneStep : Tuning
    {
        public TuningTuneDownOneStep()
            : base("D", "G", "C", "F", "A", "D")
        {
        }

        public override string GetName()
        {
            return "Tune down 1 step";
        }
    }
}