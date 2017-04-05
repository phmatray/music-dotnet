using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core
{
    public partial class Step
    {
        public static List<Step> CreateAll()
        {
            return Enum.GetValues(typeof(StepAlias))
                .Cast<StepAlias>()
                .Select(Create)
                .ToList();
        }

        public static Step Create(StepAlias alias)
        {
            switch (alias)
            {
                case StepAlias.Cb:
                    return new Step { Name = new StepNameC(), Accidental = new StepAccidentalFlat() };
                case StepAlias.C:
                    return new Step { Name = new StepNameC(), Accidental = new StepAccidentalNatural() };
                case StepAlias.CSharp:
                    return new Step { Name = new StepNameC(), Accidental = new StepAccidentalSharp() };
                case StepAlias.Db:
                    return new Step { Name = new StepNameD(), Accidental = new StepAccidentalFlat() };
                case StepAlias.D:
                    return new Step { Name = new StepNameD(), Accidental = new StepAccidentalNatural() };
                case StepAlias.DSharp:
                    return new Step { Name = new StepNameD(), Accidental = new StepAccidentalSharp() };
                case StepAlias.Eb:
                    return new Step { Name = new StepNameE(), Accidental = new StepAccidentalFlat() };
                case StepAlias.E:
                    return new Step { Name = new StepNameE(), Accidental = new StepAccidentalNatural() };
                case StepAlias.ESharp:
                    return new Step { Name = new StepNameE(), Accidental = new StepAccidentalSharp() };
                case StepAlias.Fb:
                    return new Step { Name = new StepNameF(), Accidental = new StepAccidentalFlat() };
                case StepAlias.F:
                    return new Step { Name = new StepNameF(), Accidental = new StepAccidentalNatural() };
                case StepAlias.FSharp:
                    return new Step { Name = new StepNameF(), Accidental = new StepAccidentalSharp() };
                case StepAlias.Gb:
                    return new Step { Name = new StepNameG(), Accidental = new StepAccidentalFlat() };
                case StepAlias.G:
                    return new Step { Name = new StepNameG(), Accidental = new StepAccidentalNatural() };
                case StepAlias.GSharp:
                    return new Step { Name = new StepNameG(), Accidental = new StepAccidentalSharp() };
                case StepAlias.Ab:
                    return new Step { Name = new StepNameA(), Accidental = new StepAccidentalFlat() };
                case StepAlias.A:
                    return new Step { Name = new StepNameA(), Accidental = new StepAccidentalNatural() };
                case StepAlias.ASharp:
                    return new Step { Name = new StepNameA(), Accidental = new StepAccidentalSharp() };
                case StepAlias.Bb:
                    return new Step { Name = new StepNameB(), Accidental = new StepAccidentalFlat() };
                case StepAlias.B:
                    return new Step { Name = new StepNameB(), Accidental = new StepAccidentalNatural() };
                case StepAlias.BSharp:
                    return new Step { Name = new StepNameB(), Accidental = new StepAccidentalSharp() };
                default:
                    throw new ArgumentOutOfRangeException(nameof(alias), alias, null);
            }
        }
    }
}