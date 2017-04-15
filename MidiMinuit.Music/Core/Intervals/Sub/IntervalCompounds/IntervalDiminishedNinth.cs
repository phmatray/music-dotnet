using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalDiminishedNinth
        : IntervalCompound
    {
        public IntervalDiminishedNinth()
        {
        }

        public IntervalDiminishedNinth(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.DiminishedNinth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Parfaite;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Ninth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d9", "°9", "deg. 9", "dim. 9" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 12;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalNinth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Ninth");

        public override string WikipediaDescription { get; }
            = @"In music, a ninth is a compound interval consisting of an octave plus a second.

Like the second, the interval of a ninth is classified as a dissonance in common practice tonality. Since a ninth is an octave larger than a second, its sonority level is considered less dense.";

        public override string ToString()
            => Abbreviation;
    }
}