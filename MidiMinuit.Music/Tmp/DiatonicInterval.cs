using System;

namespace MidiMinuit.Music.Tmp
{
    public class DiatonicInterval
    {
        public static DiatonicInterval Unison => new DiatonicInterval(1);
        public static DiatonicInterval Second => new DiatonicInterval(2);
        public static DiatonicInterval Third => new DiatonicInterval(3);
        public static DiatonicInterval Fourth => new DiatonicInterval(4);
        public static DiatonicInterval Fifth => new DiatonicInterval(5);
        public static DiatonicInterval Sixth => new DiatonicInterval(6);
        public static DiatonicInterval Seventh => new DiatonicInterval(7);
        public static DiatonicInterval Octave => new DiatonicInterval(8);


        public int Steps { get; protected set; }

        public DiatonicInterval(int steps)
        {
            Steps = steps;
        }

        public DiatonicInterval MakeAscending()
        {
            return new DiatonicInterval(Math.Abs(Steps));
        }

        public DiatonicInterval MakeDescending()
        {
            return new DiatonicInterval(Math.Abs(Steps) * -1);
        }

        ////public Interval ToInterval(int halftones)
        ////{
        ////    return new Interval(Steps, halftones);
        ////}
    }
}