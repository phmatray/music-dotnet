using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalMajorNinth
        : IntervalCompound
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
            = new Uri("https://en.wikipedia.org/wiki/Ninth#Major_ninth");

        public override string WikipediaDescription { get; }
            = @"A major ninth is a compound musical interval spanning 14 semitones, or an octave plus 2 semitones. If transposed into a single octave, it becomes a major second or minor seventh. The major ninth is somewhat dissonant in sound.";

        public override string ToString()
            => Abbreviation;
    }
}