using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalMajorSixth
        : Interval
    {
        public IntervalMajorSixth()
        {
        }

        public IntervalMajorSixth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.MajorSixth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> Names { get; }
            = new List<string>
            {
                "Major Sixth",
                "Septimal Major Sixth",
                "Supermajor Sixth",
                "Major Hexachord",
                "Greater Hexachord",
                "Hexachordon Maius"
            };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M6", "Maj. 6" };

        public override string QualityComposition { get; }
            = "4 tons et 1 demi-ton diatonique";

        public override int Semitones { get; }
            = 9;

        public override IntervalStep Step { get; }
            = new IntervalStepSixth();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Major_sixth");

        public override string WikipediaDescription { get; }
            = @"In music from Western culture, a sixth is a musical interval encompassing six note letter names or staff positions, and the major sixth is one of two commonly occurring sixths. It is qualified as major because it is the larger of the two. The major sixth spans nine semitones. Its smaller counterpart, the minor sixth, spans eight semitones. For example, the interval from C up to the nearest A is a major sixth. It's a sixth because it encompasses six note letter names (C, D, E, F, G, A) and six staff positions. It's a major sixth, not a minor sixth, because the note A lies nine semitones above C. Diminished and augmented sixths (such as C♯ to A♭ and C to A♯) span the same number of note letter names and staff positions, but consist of a different number of semitones (seven and ten).";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}