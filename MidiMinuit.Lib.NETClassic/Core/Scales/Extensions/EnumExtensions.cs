namespace MidiMinuit.Lib.Core.Scales
{
    public static class EnumExtensions
    {
        public static int GetValue(this ScaleTypeEnum scaleType)
            => (int)scaleType;
    }
}