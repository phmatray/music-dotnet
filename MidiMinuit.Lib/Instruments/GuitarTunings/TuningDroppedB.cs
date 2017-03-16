namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningDroppedB : GuitarTuning
    {
        public TuningDroppedB()
            : base("B", "G♭", "B", "E", "A♭", "D♭")
        {
        }

        public override string GetName()
        {
            return "Dropped B";
        }
    }
}