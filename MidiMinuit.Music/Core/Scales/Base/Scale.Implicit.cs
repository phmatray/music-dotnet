namespace MidiMinuit.Music.Core
{
    public partial class Scale
    {
        public static implicit operator ScaleAlias(Scale scale)
            => scale.Alias;

        public static implicit operator Scale(ScaleAlias alias)
            => Create(alias);
    }
}