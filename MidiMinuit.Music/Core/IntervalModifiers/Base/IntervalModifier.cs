namespace MidiMinuit.Music.Core.IntervalModifiers
{
    public abstract class IntervalModifier
    {
        public static implicit operator IntervalModifier(IntervalModifierAlias alias)
        {
            var repo = new IntervalModifierRepository();
            var modifier = repo.Get(alias);
            return modifier;
        }

        public static implicit operator IntervalModifierAlias(IntervalModifier modifier)
        {
            return modifier.Alias;
        }

        public abstract IntervalModifierAlias Alias { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract IntervalModifier Inverse();

        public abstract override string ToString();

        public abstract IntervalModifier Clone();
    }
}