namespace MidiMinuit.Lib.Core.IntervalNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntervalNumberFactory
    {
        public virtual List<IntervalNumber> CreateAllIntervalNumbers()
        {
            return Enum.GetValues(typeof(IntervalNumberAlias))
                .Cast<IntervalNumberAlias>()
                .Select(CreateIntervalNumber)
                .ToList();
        }

        public virtual IntervalNumber CreateIntervalNumber(IntervalNumberAlias number)
        {
            switch (number)
            {
                case IntervalNumberAlias.Unison:
                    return new IntervalNumberUnison();
                case IntervalNumberAlias.Second:
                    return new IntervalNumberSecond();
                case IntervalNumberAlias.Third:
                    return new IntervalNumberThird();
                case IntervalNumberAlias.Fourth:
                    return new IntervalNumberFourth();
                case IntervalNumberAlias.Fifth:
                    return new IntervalNumberFifth();
                case IntervalNumberAlias.Sixth:
                    return new IntervalNumberSixth();
                case IntervalNumberAlias.Seventh:
                    return new IntervalNumberSeventh();
                case IntervalNumberAlias.Octave:
                    return new IntervalNumberOctave();
                default:
                    throw new ArgumentOutOfRangeException(nameof(number), number, null);
            }
        }
    }
}