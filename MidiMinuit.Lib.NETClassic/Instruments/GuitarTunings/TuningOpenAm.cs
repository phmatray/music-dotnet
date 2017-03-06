namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenAm : Tuning
    {
        public TuningOpenAm()
            : base("E", "A", "E", "A", "C", "E")
        {
        }

        public override string GetName()
        {
            return "Open Am";
        }
    }
}