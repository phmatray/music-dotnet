using System;

namespace ConsoleApp1.IntervalModifiers
{
    public abstract class IntervalModifier
    {
        public abstract Modifier Modifier { get; }

        public abstract string Name { get; }

        public abstract string Abbreviation { get; }

        public abstract IntervalModifier Inverse();

        public abstract override string ToString();

        public abstract IntervalModifier Clone();
    }
}


