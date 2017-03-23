using System;
using System.Collections.Generic;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.IntervalNumbers;
using ConsoleApp1.Intervals;
using MidiMinuit.Lib.Core.Notes;

// voir https://en.wikipedia.org/wiki/Interval_(music)

namespace ConsoleApp1.IntervalsOld
{
    public class Interval
    {
        public Interval(Note lowerNote, Note upperNote)
        {
            if (lowerNote == null)
            {
                throw new ArgumentNullException(nameof(lowerNote));
            }

            if (upperNote == null)
            {
                throw new ArgumentNullException(nameof(upperNote));
            }

            var semitones = UpperNote.Pitch - LowerNote.Pitch;
            var number = GetIntervalNumber(lowerNote, upperNote);
            var modifier = GetIntervalModifier(number, semitones);

            LowerNote = lowerNote;
            UpperNote = upperNote;
            Semitones = semitones;
            Number = number;
            Modifier = modifier;

            Spanning = IntervalSpanning.Simple;
        }

        public Interval(IntervalAlias quality, Note lowerNote)
        {
            if (lowerNote == null)
            {
                throw new ArgumentNullException(nameof(lowerNote));
            }

            var upperNote = GetUpperNote(lowerNote, quality);

            LowerNote = lowerNote;
            UpperNote = upperNote;
            throw new NotImplementedException();
        }

        public Note LowerNote { get; }

        public Note UpperNote { get; }

        public int Semitones { get; }

        public IntervalAlias Quality { get; }

        public virtual IntervalNumber Number { get; }

        public virtual IntervalModifier Modifier { get; }

        public virtual IntervalSpanning Spanning { get; }


        /// <summary>
        ///     Gets the interval class
        ///     An interval class is the shortest distance in pitch class space between two unordered pitch classes.
        /// </summary>
        /// <returns>The interval class</returns>
        public int IntervalClass
            => MusicMathFormulaHelpers.InvervalClass(Semitones);

        public double GetRatio()
        {
            /* In physical terms, an interval is the ratio between two sonic frequencies. 
             * For example, any two notes an octave apart have a frequency ratio of 2:1.
             * This means that successive increments of pitch by the same interval result
             * in an exponential increase of frequency, even though the human ear perceives 
             * this as a linear increase in pitch.For this reason, intervals are often 
             * measured in cents, a unit derived from the logarithm of the frequency ratio.
             */

            throw new NotImplementedException();
        }

        public double GetFrequencyRatio()
        {
            throw new NotImplementedException();
        }

        public double GetCents()
        {
            // TODO: Prendre en considération l'octave dans lequel se trouve les notes.
            return MusicMathFormulaHelpers.CentValueDeterminationOfAnInterval(LowerNote.GetFrequency(), UpperNote.GetFrequency());
        }

        public string GetName()
        {
            return $"{LowerNote}-{UpperNote}";
        }

        public List<Interval> GetEnharmonicIntervals()
        {
            /*
             * Two intervals are considered enharmonic, or enharmonically equivalent, 
             * if they both contain the same pitches spelled in different ways; that is,
             * if the notes in the two intervals are themselves enharmonically equivalent.
             * Enharmonic intervals span the same number of semitones.
             * 
             * major third (F#-A#) == major third (Gb-Bb) == diminished fourth (F#-Bb) == doubly augmented second (Gb-A#)
             */

            throw new NotImplementedException();
        }

        private static IntervalNumber GetIntervalNumber(Note lowerNote, Note upperNote)
        {
            /*
             * You find the number by counting up the letters from your first 
             * note to your last. So let's say we wanted to find the number 
             * of the interval from C to A. Starting on C (counted as 1), 
             * we count up six letters (C D E F G A) to get to A, making C 
             * up to A an interval of a 6th.
             */

            if (lowerNote == null)
            {
                throw new ArgumentNullException(nameof(lowerNote));
            }

            if (upperNote == null)
            {
                throw new ArgumentNullException(nameof(upperNote));
            }

            var number = upperNote.Name.Order - lowerNote.Name.Order + 1;
            if (number < 0)
            {
                number += 7;
            }

            return new IntervalNumberRepository().Get(number);
        }

        private static IntervalModifier GetIntervalModifier(IntervalNumber number, int semitones)
        {
            /*
             * https://www.musictheory.net/vc/5/0/7598f92867fe9f86b7843fa8b8260926e0dd2aa9/lesson31_1580.png
             */

            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }

            if (semitones < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(semitones));
            }

            if (number.Alias == IntervalNumbers.IntervalNumberAlias.Unison)
            {
                switch (semitones)
                {
                    case 0:
                        return new IntervalModifierPerfect();
                    case 1:
                        return new IntervalModifierAugmented();
                }
            }
            else if (number.Alias == IntervalNumbers.IntervalNumberAlias.Second)
            {
                switch (semitones)
                {
                    case 0:
                        return new IntervalModifierDiminished();
                    case 1:
                        return new IntervalModifierMinor();
                    case 2:
                        return new IntervalModifierMajor();
                    case 3:
                        return new IntervalModifierAugmented();
                }
            }
            else if (number.Alias == IntervalNumbers.IntervalNumberAlias.Third)
            {
                switch (semitones)
                {
                    case 2:
                        return new IntervalModifierDiminished();
                    case 3:
                        return new IntervalModifierMinor();
                    case 4:
                        return new IntervalModifierMajor();
                    case 5:
                        return new IntervalModifierAugmented();
                }
            }
            else if (number.Alias == IntervalNumbers.IntervalNumberAlias.Fourth)
            {
                switch (semitones)
                {
                    case 4:
                        return new IntervalModifierDiminished();
                    case 5:
                        return new IntervalModifierPerfect();
                    case 6:
                        return new IntervalModifierAugmented();
                }
            }
            else if (number.Alias == IntervalNumbers.IntervalNumberAlias.Fifth)
            {
                switch (semitones)
                {
                    case 6:
                        return new IntervalModifierDiminished();
                    case 7:
                        return new IntervalModifierPerfect();
                    case 8:
                        return new IntervalModifierAugmented();
                }
            }
            else if (number.Alias == IntervalNumbers.IntervalNumberAlias.Sixth)
            {
                switch (semitones)
                {
                    case 7:
                        return new IntervalModifierDiminished();
                    case 8:
                        return new IntervalModifierMinor();
                    case 9:
                        return new IntervalModifierMajor();
                    case 10:
                        return new IntervalModifierAugmented();
                }
            }
            else if (number.Alias == IntervalNumbers.IntervalNumberAlias.Seventh)
            {
                switch (semitones)
                {
                    case 9:
                        return new IntervalModifierDiminished();
                    case 10:
                        return new IntervalModifierMinor();
                    case 11:
                        return new IntervalModifierMajor();
                    case 12:
                        return new IntervalModifierAugmented();
                }
            }
            else if (number.Alias == IntervalNumbers.IntervalNumberAlias.Seventh)
            {
                switch (semitones)
                {
                    case 11:
                        return new IntervalModifierDiminished();
                    case 12:
                        return new IntervalModifierPerfect();
                    case 13:
                        return new IntervalModifierAugmented();
                }
            }

            throw new ArgumentOutOfRangeException();
        }

        private static Note GetUpperNote(Note lowerNote, IntervalAlias quality)
        {
            return null;
            switch (quality)
            {
                case IntervalAlias.IntervalPerfectUnison:
                    break;
                case IntervalAlias.IntervalPerfectFourth:
                    break;
                case IntervalAlias.IntervalPerfectFifth:
                    break;
                case IntervalAlias.IntervalPerfectOctave:
                    break;
                case IntervalAlias.IntervalMajorSecond:
                    break;
                case IntervalAlias.IntervalMajorThird:
                    break;
                case IntervalAlias.IntervalMajorSixth:
                    break;
                case IntervalAlias.IntervalMajorSeventh:
                    break;
                case IntervalAlias.IntervalMinorSecond:
                    break;
                case IntervalAlias.IntervalMinorThird:
                    break;
                case IntervalAlias.IntervalMinorSixth:
                    break;
                case IntervalAlias.IntervalMinorSeventh:
                    break;
                case IntervalAlias.IntervalAugmentedUnison:
                    break;
                case IntervalAlias.IntervalAugmentedSecond:
                    break;
                case IntervalAlias.IntervalAugmentedThird:
                    break;
                case IntervalAlias.IntervalAugmentedFourth:
                    break;
                case IntervalAlias.IntervalAugmentedFifth:
                    break;
                case IntervalAlias.IntervalAugmentedSixth:
                    break;
                case IntervalAlias.IntervalAugmentedSeventh:
                    break;
                case IntervalAlias.IntervalAugmentedOctave:
                    break;
                case IntervalAlias.IntervalDiminishedSecond:
                    break;
                case IntervalAlias.IntervalDiminishedThird:
                    break;
                case IntervalAlias.IntervalDiminishedFourth:
                    break;
                case IntervalAlias.IntervalDiminishedFifth:
                    break;
                case IntervalAlias.IntervalDiminishedSixth:
                    break;
                case IntervalAlias.IntervalDiminishedSeventh:
                    break;
                case IntervalAlias.IntervalDiminishedOctave:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(quality), quality, null);
            }
        }

        public override string ToString()
        {
            return $"{GetName()} ({Modifier.Abbreviation}{Number.Value})";
        }
    }

    public enum IntervalClassification1
    {
        /*
         * An interval can be described as
         * - Vertical or harmonic if the two notes sound simultaneously
         * - Horizontal, linear, or melodic if they sound successively.
         */

        Melodic,
        Harmonic
    }

    public enum IntervalClassification2
    {
        // /!\ CONTROVERSIAL

        /*
         * In general,
         * - A diatonic interval is an interval formed by two notes of a diatonic scale.
         * - A chromatic interval is a non-diatonic interval formed by two notes of a chromatic scale.
         */

        Diatonic,
        Chromatic
    }
}


