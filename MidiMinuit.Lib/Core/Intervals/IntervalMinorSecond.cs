namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;

    public class IntervalMinorSecond
        : Interval
    {
        public IntervalMinorSecond()
        {
        }

        public IntervalMinorSecond(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMinorSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Minor Second", "Semitone", "Half Tone", "Half Step" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "m2", "min. 2" };

        public override string QualityComposition { get; }
            = "1 demi-ton diatonique";

        public override int Semitones { get; }
            = 1;

        public override IntervalNumber Number { get; }
            = new IntervalNumberSecond();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMinor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string WikipediaDescription { get; }
            = @"Melodically, this interval is very frequently used, and is of particular importance in cadences. In the perfect and deceptive cadences it appears as a resolution of the leading-tone to the tonic. In the plagal cadence, it appears as the falling of the subdominant to the mediant. It also occurs in many forms of the imperfect cadence, wherever the tonic falls to the leading-tone.

Harmonically, the interval usually occurs as some form of dissonance or a nonchord tone that is not part of the functional harmony. It may also appear in inversions of a major seventh chord, and in many added tone chords.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}