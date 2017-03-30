using System.Collections.Generic;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalNumbers;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalDiminishedSeventh
        : Interval
    {
        public IntervalDiminishedSeventh()
        {
        }

        public IntervalDiminishedSeventh(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedSeventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Seventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d7", "°7", "deg. 7", "dim. 7" };

        public override string QualityComposition { get; }
            = "3 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 9;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSeventh();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a diminished seventh is an interval produced by narrowing a minor seventh by a chromatic semitone. For instance, the interval from A to G is a minor seventh, ten semitones wide, and both the intervals from A♯ to G, and from A to G♭ are diminished sevenths, spanning nine semitones. Being diminished, it is considered a dissonant interval.

The diminished seventh is enharmonically equivalent to a major sixth. Its inversion is the augmented second.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}