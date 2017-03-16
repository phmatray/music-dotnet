namespace MidiMinuit.Lib.Core.Degrees.Base
{
    using System;

    public class DegreeFactory
    {
        public virtual Degree CreateDegree(DegreeNumberEnum degree)
        {
            switch (degree)
            {
                case DegreeNumberEnum.I:
                    return new Degree1();
                case DegreeNumberEnum.II:
                    return new Degree2();
                case DegreeNumberEnum.III:
                    return new Degree3();
                case DegreeNumberEnum.IV:
                    return new Degree4();
                case DegreeNumberEnum.V:
                    return new Degree5();
                case DegreeNumberEnum.VI:
                    return new Degree6();
                case DegreeNumberEnum.VII:
                    return new Degree7();
                case DegreeNumberEnum.VIII:
                    return new Degree8();
                default:
                    throw new ArgumentOutOfRangeException(nameof(degree));
            }
        }
    }
}
