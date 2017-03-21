using ConsoleApp1.Intervals;
using MidiMinuit.Lib.Core.Notes;

namespace ConsoleApp1.IntervalsOld
{
    public abstract class IntervalSimple
        : Interval
    {
        public IntervalSimple(Note lowerNote, Note upperNote)
            : base(lowerNote, upperNote)
        {
        }

        public IntervalSimple(IntervalQuality quality, Note lowerNote)
            : base(quality, lowerNote)
        {
        }


        public abstract Interval Inverse();






        ////public Interval InverseRaisingLower()
        ////{
        ////    /*
        ////     * A simple interval (i.e., an interval smaller than or equal to an octave) 
        ////     * may be inverted by raising the lower pitch an octave, or lowering the upper
        ////     * pitch an octave. For example, the fourth from a lower C to a higher F may 
        ////     * be inverted to make a fifth, from a lower F to a higher C.
        ////     */

        ////    return new IntervalSimple(UpperNote, LowerNote);
        ////}

        ////public Interval InverseLoweringUpper()
        ////{
        ////    /*
        ////     * TODO: UnitTests
        ////     * https://en.wikipedia.org/wiki/Interval_(music)#Inversion
        ////     */

        ////    return new IntervalSimple(UpperNote, LowerNote);
        ////}
    }
}