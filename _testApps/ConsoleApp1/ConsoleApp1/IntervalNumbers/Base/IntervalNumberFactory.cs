using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.IntervalNumbers
{
    public class IntervalNumberFactory
    {
        public virtual List<IntervalNumber> CreateAllIntervalNumbers()
        {
            return Enum.GetValues(typeof(Number))
                .Cast<Number>()
                .Select(CreateIntervalNumber)
                .ToList();
        }

        public virtual IntervalNumber CreateIntervalNumber(Number number)
        {
            switch (number)
            {
                case Number.Unison:
                    return new IntervalNumberUnison();
                case Number.Second:
                    return new IntervalNumberSecond();
                case Number.Third:
                    return new IntervalNumberThird();
                case Number.Fourth:
                    return new IntervalNumberFourth();
                case Number.Fifth:
                    return new IntervalNumberFifth();
                case Number.Sixth:
                    return new IntervalNumberSixth();
                case Number.Seventh:
                    return new IntervalNumberSeventh();
                case Number.Octave:
                    return new IntervalNumberOctave();
                default:
                    throw new ArgumentOutOfRangeException(nameof(number), number, null);
            }
        }
    }
}