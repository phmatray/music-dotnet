namespace OpenJam.Music.Core
{
    public abstract partial class IntervalModifier
    {
        public abstract IntervalModifierAlias Alias { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract IntervalModifier Inverse();

        public abstract override string ToString();
    }
}