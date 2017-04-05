using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalDiminishedFifth
        : Interval
    {
        public IntervalDiminishedFifth()
        {
        }

        public IntervalDiminishedFifth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.DiminishedFifth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Fifth", "Tritone" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d5", "°5", "TT", "deg. 5", "dim. 5" };

        public override string QualityComposition { get; }
            = "2 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 6;

        public override IntervalStep Step { get; }
            = new IntervalStepFifth();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Tritone");

        public override string WikipediaDescription { get; }
            = @"In music theory, the tritone is strictly defined as a musical interval composed of three adjacent whole tones. For instance, the interval from F up to the B above it (in short, F–B) is a tritone as it can be decomposed into the three adjacent whole tones F–G, G–A, and A–B. According to this definition, within a diatonic scale there is only one tritone for each octave. For instance, the above-mentioned interval F–B is the only tritone formed from the notes of the C major scale. A tritone is also commonly defined as an interval spanning six semitones. According to this definition, a diatonic scale contains two tritones for each octave. For instance, the above-mentioned C major scale contains the tritones F–B (from F to the B above it, also called augmented fourth) and B–F (from B to the F above it, also called diminished fifth, semidiapente, or semitritonus). In twelve-equal temperament, the tritone divides the octave exactly in half.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}