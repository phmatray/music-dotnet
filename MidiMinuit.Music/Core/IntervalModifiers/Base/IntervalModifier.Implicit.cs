namespace MidiMinuit.Music.Core
{
    public partial class IntervalModifier
    {
        public static implicit operator IntervalModifierAlias(IntervalModifier modifier)
            => modifier.Alias;

        public static implicit operator IntervalModifier(IntervalModifierAlias alias)
            => Create(alias);
    }
}