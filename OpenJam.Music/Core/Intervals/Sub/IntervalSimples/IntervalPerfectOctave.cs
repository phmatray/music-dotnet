using System;
using System.Collections.Generic;

namespace OpenJam.Music.Core
{
    public class IntervalPerfectOctave
        : IntervalSimple
    {
        public IntervalPerfectOctave()
        {
        }

        public IntervalPerfectOctave(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.PerfectOctave;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Perfect Octave" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "P8", "Perf. 8" };

        public override string QualityComposition { get; }
            = "5 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 12;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalOctave();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierPerfect();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Octave");

        public override string WikipediaDescription { get; }
            = @"In music, an octave (Latin: octavus: eighth) or perfect octave is the interval between one musical pitch and another with half or double its frequency. It is defined by ANSI as the unit of frequency level when the base of the logarithm is two. The octave relationship is a natural phenomenon that has been referred to as the ""basic miracle of music"", the use of which is ""common in most musical systems"".";

        public override string ToString()
            => Abbreviation;
    }
}