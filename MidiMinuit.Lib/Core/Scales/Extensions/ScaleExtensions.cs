namespace MidiMinuit.Lib.Core.Scales.Extensions
{
    public static class ScaleExtensions
    {
        public static ScaleMajor GetRelativeMajor(this ScaleMinorNaturalEolian scale)
            => new ScaleMajor(scale.Fondamental + 3);

        public static ScaleMinorNaturalEolian GetRelativeMajor(this ScaleMajor scale)
            => new ScaleMinorNaturalEolian(scale.Fondamental - 3);
    }
}
