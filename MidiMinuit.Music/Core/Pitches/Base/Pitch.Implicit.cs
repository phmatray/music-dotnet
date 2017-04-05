namespace MidiMinuit.Music.Core.Pitches
{
    public partial class Pitch
    {
        public static implicit operator Pitch(PitchAlias alias)
            => Create(alias);
    }
}