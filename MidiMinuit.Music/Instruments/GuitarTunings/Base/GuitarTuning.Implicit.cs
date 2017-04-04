namespace MidiMinuit.Music.Instruments.GuitarTunings
{
    public partial class GuitarTuning
    {
        public static implicit operator GuitarTuningAlias(GuitarTuning guitarTuning)
            => guitarTuning.Alias;

        public static implicit operator GuitarTuning(GuitarTuningAlias alias)
            => Create(alias);
    }
}