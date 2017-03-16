namespace MidiMinuit.Lib.Instruments.GuitarTunings
{
    public static class EnumExtensions
    {
        public static int GetValue(this GuitarTuningType tuningType)
            => (int)tuningType;
    }
}