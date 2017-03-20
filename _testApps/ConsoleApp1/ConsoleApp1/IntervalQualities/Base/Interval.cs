using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.Intervals;

namespace ConsoleApp1.IntervalQualities
{
    public abstract class Interval
    {
        public abstract int Semitones { get; }

        public abstract IntervalNumber Number { get; }

        public abstract IntervalModifier Modifier { get; }

        public abstract IntervalSpanning Spanning { get; }

        public abstract IntervalQuality Quality { get; }

        public abstract List<string> QualityName { get; }

        public abstract List<string> QualityAbbreviation { get; }

        public abstract List<string> QualityAbbreviation2 { get; }

        public abstract string QualityComposition { get; }

        public string Abbreviation
            => $"{Modifier.Abbreviation}{Number.Value}";

        public abstract override string ToString();

        public abstract Interval Clone();
    }
}