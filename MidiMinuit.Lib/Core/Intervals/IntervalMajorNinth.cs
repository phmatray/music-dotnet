namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMajorNinth
        : Interval
    {
        public IntervalMajorNinth()
        {
        }

        public IntervalMajorNinth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorNinth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Major Ninth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M9", "Maj. 9" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 14;

        public override IntervalNumber Number { get; }
            = new IntervalNumberNinth();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override string WikipediaDescription { get; }
            = "NO DATA";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}