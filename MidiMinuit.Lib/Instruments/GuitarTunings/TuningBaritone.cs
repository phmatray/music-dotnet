namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningBaritone : GuitarTuning
    {
        public TuningBaritone()
            : base("B", "E", "A", "D", "G♭", "B")
        {
        }

        public override string GetName()
        {
            return "Baritone";
        }
    }
}