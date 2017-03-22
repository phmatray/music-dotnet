using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;
using MidiMinuit.Lib.Core.Notes;

namespace ConsoleApp1.Intervals
{
    public abstract class Interval
    {
        /* Possibilités d'évolution
         * --------------------------------------
         * Additionner une note et un interval: ex: Note.C + Interval.PerfectFifth = Note.G
         * Additionner 2 intervals pour obtenir un interval composé: ex: Interval.Octave + Interval.MinorSecond = Interval.Ninth
         */

        public Note LowerNote { get; }

        public Note UpperNote { get; }

        public abstract int Semitones { get; }

        public abstract IntervalNumber Number { get; }

        public abstract IntervalModifier Modifier { get; }

        public abstract IntervalSpanning Spanning { get; }

        public abstract IntervalQuality Quality { get; }

        public abstract IntervalConsonance HarmonicConsonance { get; }

        public abstract List<string> QualityName { get; }

        public abstract List<string> QualityAbbreviation { get; }

        public abstract List<string> QualityAbbreviation2 { get; }

        public abstract string QualityComposition { get; }

        public string Abbreviation
            => $"{Modifier.Abbreviation}{Number.Value}";

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