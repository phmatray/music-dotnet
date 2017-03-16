namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenEsus11 : GuitarTuning
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