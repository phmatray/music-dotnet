namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public class TuningLuteOrVihuela : Tuning
    {
        public TuningLuteOrVihuela()
            : base("E", "A", "D", "G♭", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Lute or Vihuela";
        }
    }
}