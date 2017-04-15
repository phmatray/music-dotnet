using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalDiminishedEleventh
        : IntervalCompound
    {
        public IntervalDiminishedEleventh()
        {
        }

        public IntervalDiminishedEleventh(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.DiminishedEleventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Eleventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d11", "°11", "deg. 11", "dim. 11" };

        public override string QualityComposition { get; }
            = "1 octave et 1 ton et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 16;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalEleventh();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Eleventh");

        public override string WikipediaDescription { get; }
            = @"In music or music theory an eleventh is the note eleven scale degrees from the root of a chord and also the interval between the root and the eleventh. The interval can be also described as a compound fourth, spanning an octave plus a fourth.";

        public override string ToString()
            => Abbreviation;
    }
}