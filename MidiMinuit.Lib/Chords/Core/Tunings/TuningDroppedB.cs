using MidiMinuit.Lib.Chords.Core.Tunings.Base;

namespace MidiMinuit.Lib.Chords.Core.Tunings
{
    public class TuningDroppedB : Tuning
    {
        public TuningDroppedB()
            : base("B", "Gb", "B", "E", "Ab", "Db")
        {
        }

        public override string GetName()
        {
            return "Dropped B";
        }
    }
}