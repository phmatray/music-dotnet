namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningNashville : GuitarTuning
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