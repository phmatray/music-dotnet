namespace MidiMinuit.Lib.Core.IntervalModifiers
{
    public abstract class IntervalModifier
    {
        public abstract IntervalModifierAlias Alias { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract IntervalModifier Inverse();

        public abstract override string ToString();

        public abstract IntervalModifier Clone();
    }
}


