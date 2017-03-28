namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using System.Linq;
    using IntervalModifiers;
    using IntervalNumbers;
    using Notes;
    using Tools;

    public abstract class Interval
    {
        /* Possibilités d'évolution
         * --------------------------------------
         * Additionner une note et un interval: ex: Note.C + Interval.PerfectFifth = Note.G
         * Additionner 2 intervals pour obtenir un interval composé: ex: Interval.Octave + Interval.MinorSecond = Interval.Ninth
         */

        private Note _lowerNote;

        protected Interval()
        {
        }

        protected Interval(Note lowerNote)
        {
            LowerNote = lowerNote;
            UpperNote = lowerNote.AddInterval(this);
        }

        public Note LowerNote
        {
            get
            {
                return _lowerNote;
            }

            set
            {
                _lowerNote = value;
                UpperNote = _lowerNote.AddInterval(this);
            }
        }

        public Note UpperNote { get; private set; }

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
            => $"{LowerNote.Details} - {UpperNote.Details}";

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
            => MusicMathFormulaHelpers.InvervalClass(Semitones);

        public abstract override string ToString();

        public abstract Interval Clone();
    }
}