using System.Collections.Generic;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalNumbers;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalDiminishedOctave
        : Interval
    {
        public IntervalDiminishedOctave()
        {
        }

        public IntervalDiminishedOctave(Pitch lowerPitch)
            : base(lowerPitch)
        {
        }

        public override IntervalAlias Alias { get; }
            = IntervalAlias.IntervalDiminishedOctave;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Octave", "Diminished Eighth" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d8", "°8", "deg. 8", "dim. 8" };

        public override string QualityComposition { get; }
            = "4 tons et 3 demi-tons diatoniques";

        public override int Semitones { get; }
            = 11;

        public override IntervalStep Step { get; }
            = new IntervalStepOctave();

        public override IntervalModifier Modifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override string WikipediaDescription { get; }
            = @"In classical music from Western culture, a diminished octave is an interval produced by narrowing a perfect octave by a chromatic semitone. As such, the two notes are denoted by the same letter but have different accidentals. For instance, the interval from C4 to C5 is a perfect octave, twelve semitones wide, and both the intervals from C♯4 to C5, and from C4 to C♭5 are diminished octaves, spanning eleven semitones. Being diminished, it is considered a dissonant interval.

The diminished octave is enharmonically equivalent to the major seventh.";

        public override string ToString()
            => Abbreviation;

        public override Interval Clone()
            => MemberwiseClone() as Interval;
    }
}