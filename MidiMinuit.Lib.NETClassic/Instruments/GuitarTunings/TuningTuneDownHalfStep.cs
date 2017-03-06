namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningTuneDownHalfStep : Tuning
    {
        public TuningTuneDownHalfStep()
            : base("E♭", "A♭", "D♭", "G♭", "B♭", "E♭")
        {
        }

        public override string GetName()
        {
            return "Tune down 1/2 step";
        }
    }
}