namespace MidiMinuit.Lib.Core.Chords
{
    public static class EnumExtensions
    {
        public static int GetValue(this ChordQualityEnum chordQuality)
            => (int)chordQuality;
    }
}