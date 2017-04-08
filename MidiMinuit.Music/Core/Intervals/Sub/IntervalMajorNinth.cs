using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalMajorNinth
        : Interval
    {
        public IntervalMajorNinth()
        {
        }

        public IntervalMajorNinth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.MajorNinth;

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

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalNinth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Ninth");

        public override string WikipediaDescription { get; }
            = "NO DATA";

        public override string ToString()
            => Abbreviation;
    }
}