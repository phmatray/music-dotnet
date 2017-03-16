namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenF : GuitarTuning
    {
        public TuningOpenF()
            : base("F", "A", "C", "F", "C", "F")
        {
        }

        public override string GetName()
        {
            return "Open F";
        }
    }
}