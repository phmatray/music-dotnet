using System;
using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class IntervalDiminishedUnison
        : IntervalSimple
    {
        public IntervalDiminishedUnison()
        {
        }

        public IntervalDiminishedUnison(Pitch startingPitch)
            : base(startingPitch)
        {
        }

        public override IntervalAlias IntervalAlias { get; }
            = IntervalAlias.DiminishedUnison;

        public override IntervalConsonance HarmonicConsonance { get; }
            = IntervalConsonance.Dissonante;

        public override List<string> Names { get; }
            = new List<string> { "Diminished Unison", "Diminished Prime" };

        public override List<string> Abbreviations { get; }
            = new List<string> { "d1", "°1", "deg. 1", "dim. 1" };

        public override string QualityComposition { get; }
            = "-1 demi-ton diatoniques";

        public override int Semitones { get; }
            = -1;

        public override DiatonicInterval DiatonicInterval { get; }
            = new DiatonicIntervalUnison();

        public override IntervalModifier IntervalModifier { get; }
            = new IntervalModifierDiminished();

        public override IntervalSpanning Spanning { get; }
            = IntervalSpanning.Simple;

        public override Uri WikipediaUrl { get; }
            = new Uri("https://en.wikipedia.org/wiki/Augmented_unison#diminished_unison");

        public override string WikipediaDescription { get; }
            = @"The term diminished unison or diminished prime is also found occasionally. It is found once in Rameau's writings, for example, as well as subsequent French, German, and English sources. Other sources reject the possibility or utility of the diminished unison on the grounds that any alteration to the unison increases its size, thus augmenting rather than diminishing it.";

        public override string ToString()
            => Abbreviation;
    }
}