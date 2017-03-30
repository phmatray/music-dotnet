using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalNumbers;
using MidiMinuit.Music.Core.Notes;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Core.Intervals
{
    public abstract class Interval
    {
        /* Possibilités d'évolution
         * --------------------------------------
         * Additionner une note et un interval: ex: Note.C + Interval.PerfectFifth = Note.G
         * Additionner 2 intervals pour obtenir un interval composé: ex: Interval.Octave + Interval.MinorSecond = Interval.Ninth
         */

        private Pitch _lowerPitch;

        protected Interval()
        {
        }

        protected Interval(Pitch lowerPitch)
        {
            LowerPitch = lowerPitch;
        }

        public Pitch LowerPitch
        {
            get
            {
                return _lowerPitch;
            }

            set
            {
                _lowerPitch = value;
                UpperPitch = _lowerPitch.AddInterval(this);
            }
        }

        public Pitch UpperPitch { get; private set; }

        public abstract IntervalAlias Alias { get; }

        public abstract int Semitones { get; }

        public abstract IntervalNumber Number { get; }

        public abstract IntervalModifier Modifier { get; }

        public abstract IntervalSpanning Spanning { get; }

        public abstract IntervalConsonance HarmonicConsonance { get; }

        public abstract List<string> Names { get; }

        public abstract List<string> Abbreviations { get; }

        public abstract string QualityComposition { get; }

        public abstract string WikipediaDescription { get; }

        public string Notes
            => $"{LowerPitch.Details} - {UpperPitch.Details}";

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

        public abstract override string ToString();

        public abstract Interval Clone();
    }
}