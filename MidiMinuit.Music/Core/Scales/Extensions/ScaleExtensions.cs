namespace MidiMinuit.Music.Core
{
    public static class ScaleExtensions
    {
        public static bool HasChord(this Scale scale, Chord chord)
            => chord.IsInScale(scale);
    }
}