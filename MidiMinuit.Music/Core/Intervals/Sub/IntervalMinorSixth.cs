using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalMinorSixth
        : Interval
    {
        public IntervalMinorSixth()
        {
        }

        public IntervalMinorSixth(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.MinorSixth;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Imparfaite;

        public override List<string> Names { get; }
            = new List<string> { "Minor Sixth", "Minor Hexachord", "Hexachordon Minus", "Lesser Hexachord" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "m6", "min. 6" };

        public override string QualityComposition { get; }
            = "3 tons et 2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 8;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalSixth();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierMinor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Minor_sixth");

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a sixth is a musical interval encompassing six staff positions, and the minor sixth is one of two commonly occurring sixths. It is qualified as minor because it is the smaller of the two: the minor sixth spans eight semitones, the major sixth nine. For example, the interval from A to F is a minor sixth, as the note F lies eight semitones above A, and there are six staff positions from A to F. Diminished and augmented sixths span the same number of staff positions, but consist of a different number of semitones (seven and ten).

In equal temperament, the minor sixth is enharmonically equivalent to the augmented fifth. It occurs in first inversion major and dominant seventh chords and second inversion minor chords.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}