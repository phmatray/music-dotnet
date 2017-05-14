using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenJam.Music.Core
{
    public partial class StepAccidental
    {
        public static List<StepAccidental> CreateAll()
        {
            return Enum.GetValues(typeof(StepAccidentalAlias))
                .Cast<StepAccidentalAlias>()
                .Select(Create)
                .ToList();
        }

        public static StepAccidental Create(StepAccidentalAlias accidental)
        {
            switch (accidental)
            {
                case StepAccidentalAlias.Natural:
                    return new StepAccidentalNatural();
                case StepAccidentalAlias.Flat:
                    return new StepAccidentalFlat();
                case StepAccidentalAlias.Sharp:
                    return new StepAccidentalSharp();
                case StepAccidentalAlias.DoubleFlat:
                    return new StepAccidentalDoubleFlat();
                case StepAccidentalAlias.DoubleSharp:
                    return new StepAccidentalDoubleSharp();
                case StepAccidentalAlias.TripleFlat:
                    return new StepAccidentalTripleFlat();
                case StepAccidentalAlias.TripleSharp:
                    return new StepAccidentalTripleSharp();
                case StepAccidentalAlias.QuadrupleFlat:
                    return new StepAccidentalQuadrupleFlat();
                case StepAccidentalAlias.QuadrupleSharp:
                    return new StepAccidentalQuadrupleSharp();
                default:
                    throw new ArgumentOutOfRangeException(nameof(accidental), accidental, null);
            }
        }
    }
}