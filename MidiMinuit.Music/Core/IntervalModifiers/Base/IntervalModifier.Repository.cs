using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.IntervalModifiers
{
    public partial class IntervalModifier
    {
        internal static List<IntervalModifier> CreateAll()
        {
            return Enum.GetValues(typeof(IntervalModifierAlias))
                .Cast<IntervalModifierAlias>()
                .Select(Create)
                .ToList();
        }

        internal static IntervalModifier Create(IntervalModifierAlias modifier)
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