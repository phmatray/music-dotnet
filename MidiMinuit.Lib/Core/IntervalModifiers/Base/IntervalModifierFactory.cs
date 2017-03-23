namespace MidiMinuit.Lib.Core.IntervalModifiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntervalModifierFactory
    {
        public virtual List<IntervalModifier> CreateAllIntervalModifiers()
        {
            return Enum.GetValues(typeof(IntervalModifierAlias))
                .Cast<IntervalModifierAlias>()
                .Select(CreateIntervalModifier)
                .ToList();
        }

        public virtual IntervalModifier CreateIntervalModifier(IntervalModifierAlias modifier)
        {
            switch (modifier)
            {
                case IntervalModifierAlias.Perfect:
                    return new IntervalModifierPerfect();
                case IntervalModifierAlias.Major:
                    return new IntervalModifierMajor();
                case IntervalModifierAlias.Minor:
                    return new IntervalModifierMinor();
                case IntervalModifierAlias.Augmented:
                    return new IntervalModifierAugmented();
                case IntervalModifierAlias.Diminished:
                    return new IntervalModifierDiminished();
                default:
                    throw new ArgumentOutOfRangeException(nameof(modifier), modifier, null);
            }
        }
    }
}