namespace MidiMinuit.Music.Core
{
    public static class PitchExtensions
    {
        public static Chord ToChord(this Pitch pitch, ChordAlias chordAlias)
        {
            var chord = Chord.Create(chordAlias);
            chord.Key = pitch;
            return chord;
        }

        public static Scale ToScale(this Pitch pitch, ScaleAlias scaleAlias)
        {
            var scale = Scale.Create(scaleAlias);
            scale.Key = pitch;
            return scale;
        }
    }
}