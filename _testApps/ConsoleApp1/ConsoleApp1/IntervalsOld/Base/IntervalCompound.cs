using System;
using MidiMinuit.Lib.Core.Notes;

namespace ConsoleApp1.IntervalsOld
{
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
}