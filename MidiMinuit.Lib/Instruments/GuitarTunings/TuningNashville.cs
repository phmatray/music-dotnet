namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningNashville : Tuning
    {
        public TuningNashville()
            : base("E", "A", "D", "G", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Nashville";
        }
    }
}