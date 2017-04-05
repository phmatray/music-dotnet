using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.Degrees
{
    public partial class Degree
    {
        public static List<Degree> CreateAll()
        {
            return Enum.GetValues(typeof(DegreeAlias))
                .Cast<DegreeAlias>()
                .Select(Create)
                .ToList();
        }

        public static Degree Create(DegreeAlias degree)
        {
            switch (degree)
            {
                case DegreeAlias.I:
                    return new Degree1();
                case DegreeAlias.II:
                    return new Degree2();
                case DegreeAlias.III:
                    return new Degree3();
                case DegreeAlias.IV:
                    return new Degree4();
                case DegreeAlias.V:
                    return new Degree5();
                case DegreeAlias.VI:
                    return new Degree6();
                case DegreeAlias.VII:
                    return new Degree7();
                case DegreeAlias.VIII:
                    return new Degree8();
                default:
                    throw new ArgumentOutOfRangeException(nameof(degree));
            }
        }
    }
}