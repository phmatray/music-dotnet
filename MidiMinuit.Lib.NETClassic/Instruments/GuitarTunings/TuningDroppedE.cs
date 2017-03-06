namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningDroppedE : Tuning
    {
        public TuningDroppedE()
            : base("E", "B", "E", "A", "D♭", "G♭")
        {
        }

        public override string GetName()
        {
            return "Dropped E";
        }
    }
}