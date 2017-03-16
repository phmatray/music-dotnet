namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenAm : GuitarTuning
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