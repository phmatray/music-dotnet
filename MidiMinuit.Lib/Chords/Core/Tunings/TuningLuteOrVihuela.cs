using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
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