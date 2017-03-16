namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningOpenC : GuitarTuning
    {
        public TuningOpenC()
            : base("C", "G", "C", "G", "C", "E")
        {
        }

        public override string GetName()
        {
            return "Open C";
        }
    }
}