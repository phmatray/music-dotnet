using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

// voir https://en.wikipedia.org/wiki/Interval_(music)

namespace ConsoleApp1
{
    public static class EnumExtensions
    {

    }

    public class IntervalSimple
        : Interval
    {
        public IntervalSimple(Note lowerNote, Note upperNote)
            : base(lowerNote, upperNote)
        {
        }

        public Interval InverseRaisingLower()
        {
            /*
             * A simple interval (i.e., an interval smaller than or equal to an octave) 
             * may be inverted by raising the lower pitch an octave, or lowering the upper
             * pitch an octave. For example, the fourth from a lower C to a higher F may 
             * be inverted to make a fifth, from a lower F to a higher C.
             */

            return new IntervalSimple(UpperNote, LowerNote);
        }

        public Interval InverseLoweringUpper()
        {
            /*
             * TODO: UnitTests
             * https://en.wikipedia.org/wiki/Interval_(music)#Inversion
             */

            return new IntervalSimple(UpperNote, LowerNote);
        }
    }

    public class IntervalCompound
        : Interval
    {
        public IntervalCompound(Note lowerNote, Note upperNote)
            : base(lowerNote, upperNote)
        {
        }

        ////public IntervalCompound(List<IntervalSimple> intervals)
        ////{
        ////    /*
        ////     * In general, a compound interval may be defined by a sequence or "stack"
        ////     * of two or more simple intervals of any kind. For instance, a major tenth 
        ////     * (two staff positions above one octave), also called compound major third, 
        ////     * spans one octave plus one major third.
        ////     */

        ////    throw new NotImplementedException();
        ////}

        public IntervalSimple Simplify()
        {
            /*
             * Any compound interval can be always decomposed into one or more octaves
             * plus one simple interval. For instance, a major seventeenth can be decomposed 
             * into two octaves and one major third, and this is the reason why it is called
             * a compound major third, even when it is built by adding up four fifths.
             */

            throw new NotImplementedException();
        }
    }

    public abstract class Interval
    {
        ////public static Interval CreateInterval(Note note1, Note note2)
        ////{

        ////}


        public Note LowerNote { get; private set; }
        public Note UpperNote { get; private set; }
        public IntervalQualityEnum Quality { get; private set; }
        public IntervalNumberEnum Number { get; private set; }

        public Interval(Note lowerNote, Note upperNote)
        {
            if (lowerNote == null) throw new ArgumentNullException(nameof(lowerNote));
            if (upperNote == null) throw new ArgumentNullException(nameof(upperNote));
            
            LowerNote = lowerNote;
            UpperNote = upperNote;

            Init();
        }

        private void Init()
        {
            var gap = UpperNote.Pitch - LowerNote.Pitch; // gap == 7
            LowerNote.Name

            Quality = IntervalQualityEnum.Perfect;
            Number = IntervalNumberEnum.Fifth;
        }

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

        public override string ToString()
        {
            return $"{GetName()} ({Quality.GetAbbreviation()}{Number.GetAbbreviation()})";
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

    public enum IntervalClassification3
    {
        /*
         * Consonance and dissonance are relative terms that refer to the stability, 
         * or state of repose, of particular musical effects. Dissonant intervals are 
         * those that cause tension, and desire to be resolved to consonant intervals.
         */

        Consonant,
        Dissonant
    }

    public enum IntervalClassification4
    {
        /*
         * A simple interval is an interval spanning at most one octave (see Main intervals above).
         * Intervals spanning more than one octave are called compound intervals, as they can be
         * obtained by adding one or more octaves to a simple interval (see below for details).
         */

        Simple,
        Compound
    }
}


