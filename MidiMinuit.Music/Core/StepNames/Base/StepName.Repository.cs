using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.StepNames
{
    public partial class StepName
    {
        public static List<StepName> CreateAll()
        {
            return Enum.GetValues(typeof(StepNameAlias))
                .Cast<StepNameAlias>()
                .Select(Create)
                .ToList();
        }

        public static StepName Create(StepNameAlias name)
        {
            switch (name)
            {
                case StepNameAlias.C:
                    return new StepNameC();
                case StepNameAlias.D:
                    return new StepNameD();
                case StepNameAlias.E:
                    return new StepNameE();
                case StepNameAlias.F:
                    return new StepNameF();
                case StepNameAlias.G:
                    return new StepNameG();
                case StepNameAlias.A:
                    return new StepNameA();
                case StepNameAlias.B:
                    return new StepNameB();
                default:
                    throw new ArgumentOutOfRangeException(nameof(name), name, null);
            }
        }
    }
}