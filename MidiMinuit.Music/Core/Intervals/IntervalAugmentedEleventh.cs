using System.Collections.Generic;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalNumbers;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalAugmentedEleventh
        : Interval
    {
        public IntervalAugmentedEleventh()
        {
        }

        public IntervalAugmentedEleventh(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalAugmentedEleventh;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Augmented Eleventh" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "A11", "+11", "Aug. 11" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 18;

        public override IntervalNumber Number { get; }
            = new IntervalNumberEleventh();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierAugmented();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Compound;

        public override string WikipediaDescription { get; }
            = "NO DATA";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}