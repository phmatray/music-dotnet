using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core
{
    public partial class IntervalStep
    {
        public static List<IntervalStep> CreateAll()
        {
            return Enum.GetValues(typeof(IntervalStepAlias))
                .Cast<IntervalStepAlias>()
                .Select(Create)
                .ToList();
        }

        public static IntervalStep Create(IntervalStepAlias step)
        {
            switch (step)
            {
                case IntervalStepAlias.Unison:
                    return new IntervalStepUnison();
                case IntervalStepAlias.Second:
                    return new IntervalStepSecond();
                case IntervalStepAlias.Third:
                    return new IntervalStepThird();
                case IntervalStepAlias.Fourth:
                    return new IntervalStepFourth();
                case IntervalStepAlias.Fifth:
                    return new IntervalStepFifth();
                case IntervalStepAlias.Sixth:
                    return new IntervalStepSixth();
                case IntervalStepAlias.Seventh:
                    return new IntervalStepSeventh();
                case IntervalStepAlias.Octave:
                    return new IntervalStepOctave();
                default:
                    throw new ArgumentOutOfRangeException(nameof(step), step, null);
            }
        }
    }
}