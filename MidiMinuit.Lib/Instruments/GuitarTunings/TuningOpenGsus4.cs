namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenGsus4 : Tuning
    {
        public TuningOpenGsus4()
            : base("D", "G", "D", "G", "C", "D")
        {
        }

        public override string GetName()
        {
            return "Open Gsus4";
        }
    }
}