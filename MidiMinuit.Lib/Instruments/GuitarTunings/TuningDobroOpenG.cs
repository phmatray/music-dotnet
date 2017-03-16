namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningDobroOpenG : GuitarTuning
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