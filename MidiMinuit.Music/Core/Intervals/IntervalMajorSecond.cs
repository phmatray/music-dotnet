using System;
using System.Collections.Generic;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalNumbers;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalMajorSecond
        : Interval
    {
        public IntervalMajorSecond()
        {
        }

        public IntervalMajorSecond(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalMajorSecond;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Major Second", "Tone", "Whole Tone", "Whole Step" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "M2", "Maj. 2" };

        public override string QualityComposition { get; }
            = "1 ton";

        public override int Semitones { get; }
            = 2;

        public override IntervalStep Step { get; }
            = new IntervalStepSecond();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierMajor();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Major_second");

        public override string WikipediaDescription { get; }
            = @"In Western music theory, a major second (sometimes also called whole tone) is a second spanning two semitones. A second is a musical interval encompassing two adjacent staff positions. For example, the interval from C to D is a major second, as the note D lies two semitones above C, and the two notes are notated on adjacent staff positions. Diminished, minor and augmented seconds are notated on adjacent staff positions as well, but consist of a different number of semitones (zero, one, and three).";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}