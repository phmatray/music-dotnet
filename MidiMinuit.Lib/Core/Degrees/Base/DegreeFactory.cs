namespace MidiMinuit.Lib.Core.Degrees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DegreeFactory
    {
        public virtual List<Degree> CreateAllDegrees()
        {
            return Enum.GetValues(typeof(DegreeNumber))
                .Cast<DegreeNumber>()
                .Select(CreateDegree)
                .ToList();
        }

        public virtual Degree CreateDegree(DegreeNumber degree)
        {
            switch (degree)
            {
                case DegreeNumber.I:
                    return new Degree1();
                case DegreeNumber.II:
                    return new Degree2();
                case DegreeNumber.III:
                    return new Degree3();
                case DegreeNumber.IV:
                    return new Degree4();
                case DegreeNumber.V:
                    return new Degree5();
                case DegreeNumber.VI:
                    return new Degree6();
                case DegreeNumber.VII:
                    return new Degree7();
                case DegreeNumber.VIII:
                    return new Degree8();
                default:
                    throw new ArgumentOutOfRangeException(nameof(degree));
            }
        }
    }
}