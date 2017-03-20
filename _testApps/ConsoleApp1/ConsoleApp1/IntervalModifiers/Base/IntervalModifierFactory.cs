using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.IntervalModifiers
{
    public class IntervalModifierFactory
    {
        public virtual List<IntervalModifier> CreateAllIntervalModifiers()
        {
            return Enum.GetValues(typeof(Modifier))
                .Cast<Modifier>()
                .Select(CreateIntervalModifier)
                .ToList();
        }

        public virtual IntervalModifier CreateIntervalModifier(Modifier modifier)
        {
            switch (modifier)
            {
                case Modifier.Perfect:
                    return new IntervalModifierPerfect();
                case Modifier.Major:
                    return new IntervalModifierMajor();
                case Modifier.Minor:
                    return new IntervalModifierMinor();
                case Modifier.Augmented:
                    return new IntervalModifierAugmented();
                case Modifier.Diminished:
                    return new IntervalModifierDiminished();
                default:
                    throw new ArgumentOutOfRangeException(nameof(modifier), modifier, null);
            }
        }
    }
}