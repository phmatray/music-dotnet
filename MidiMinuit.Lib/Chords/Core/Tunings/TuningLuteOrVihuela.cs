namespace GuitarChords.Lib.Tunings
{
    public class TuningLuteOrVihuela : Tuning
    {
        public TuningLuteOrVihuela()
            : base("E", "A", "D", "Gb", "B", "E")
        {
        }

        public override string GetName()
        {
            return "Lute or Vihuela";
        }
    }
}