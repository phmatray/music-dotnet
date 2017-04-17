using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Common;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Core
{
    /*
     * Informations about simple et compound intervals
     * https://ultimatemusictheory.com/octave/
     */

    public abstract partial class Interval
        : IWikipedia
    {
        /* Possibilités d'évolution
         * --------------------------------------
         * Additionner 2 intervals pour obtenir un interval composé: ex: Interval.Octave + Interval.MinorSecond = Interval.Ninth
         */

    ////public static Interval Between(Pitch p1, Pitch p2)
    ////{
    ////    return Create(p2.ToStep().Name.StepNumber - p1.ToStep().Name.StepNumber + 1,
    ////        (p2.MidiPitch - p1.MidiPitch) % 12);
    ////}

    private Pitch _startingPitch;
        private Pitch _endingPitch;

        protected Interval()
        {
        }

        protected Interval(Pitch startingPitch)
        {
            StartingPitch = startingPitch;
        }

        public Pitch StartingPitch
        {
            get
            {
                return _startingPitch;
            }

            set
            {
                _startingPitch = value;
                _endingPitch = _startingPitch?.AddInterval(this);
            }
        }

        public Pitch EndingPitch
        {
            get
            {
                return _endingPitch;
            }

            set
            {
                _endingPitch = value;
                _startingPitch = _endingPitch?.SubstractInterval(this);
            }
        }

        public Step StartingStep
            => StartingPitch?.ToStep();

        public Step EndingStep
            => EndingPitch?.ToStep();

        public abstract IntervalAlias IntervalAlias { get; }

        public abstract IntervalSpanning Spanning { get; }

        public abstract IntervalConsonance HarmonicConsonance { get; }

        public abstract int Semitones { get; }

        public abstract DiatonicInterval DiatonicInterval { get; }

        public abstract IntervalModifier IntervalModifier { get; }

        public abstract List<string> Names { get; }

        public abstract List<string> Abbreviations { get; }

        public abstract string QualityComposition { get; }

        public abstract Uri WikipediaUrl { get; }

        public abstract string WikipediaDescription { get; }

        public bool HasPitches
            => StartingPitch != null && EndingPitch != null;

        public List<Pitch> Pitches
            => HasPitches
                ? new List<Pitch> { StartingPitch, EndingPitch }
                : null;

        public List<Step> Steps
            => HasPitches
                ? new List<Step> { StartingPitch.ToStep(), EndingPitch.ToStep() }
                : null;

        public string PitchesDetails
            => StartingPitch != null && EndingPitch != null
                ? $"{StartingPitch} to {EndingPitch}"
                : null;

        public string StepsDetails
            => StartingPitch != null && EndingPitch != null
                ? $"{StartingPitch.ToStep()} to {EndingPitch.ToStep()}"
                : null;

        public string Name
            => Names.FirstOrDefault();

        public string Abbreviation
            => Abbreviations.FirstOrDefault();

        /// <summary>
        ///     Gets the interval class
        ///     An interval class is the shortest distance in pitch class space between two unordered pitch classes.
        /// </summary>
        /// <returns>The interval class</returns>
        public int IntervalClass
            => UsefulMathHelpers.InvervalClass(Semitones);

        public abstract Interval InverseOctaveUp();

        public abstract Interval InverseOctaveDown();

        public abstract override string ToString();
    }
}