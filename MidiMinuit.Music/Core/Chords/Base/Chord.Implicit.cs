namespace MidiMinuit.Music.Core
{
    public partial class Chord
    {
        public static implicit operator ChordAlias(Chord chord)
            => chord.Alias;

        public static implicit operator Chord(ChordAlias alias)
            => Create(alias);
    }
}