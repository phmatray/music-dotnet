namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenG6 : Tuning
    {
        public TuningOpenG6()
            : base("D", "G", "D", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Open G6";
        }
    }
}