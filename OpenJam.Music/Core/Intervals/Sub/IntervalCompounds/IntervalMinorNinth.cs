using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalMinorNinth
        : IntervalCompound
    {
        public IntervalMinorNinth()
        {
        }

        public IntervalMinorNinth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.MinorNinth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Minor Ninth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "m9", "min. 9" };

        public override string QualityComposition { get; }
            = "1 octave et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 13;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalNinth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierMinor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Ninth#Minor_ninth");

        public override string WikipediaDescription { get; }
            = @"A minor ninth (m9 or -9) is a compound musical interval spanning 13 semitones, or 1 semitone above an octave (thus it is enharmonically equivalent to an augmented octave). If transposed into a single octave, it becomes a minor second or major seventh. The minor ninth is rather dissonant in sound, and in European classical music, often appears as a suspension.";

        public override string ToString()
            => Abbreviation;
    }
}