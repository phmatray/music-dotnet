using System;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Degrees
{
    public abstract class DegreeBase
    {
        public static DegreeBase GetDegree(DegreeEnum degreeEnum)
        {
            switch (degreeEnum)
            {
                case DegreeEnum.I:
                    return new Degree1();
                case DegreeEnum.II:
                    return new Degree2();
                case DegreeEnum.III:
                    return new Degree3();
                case DegreeEnum.IV:
                    return new Degree4();
                case DegreeEnum.V:
                    return new Degree5();
                case DegreeEnum.VI:
                    return new Degree6();
                case DegreeEnum.VII:
                    return new Degree7();
                case DegreeEnum.VIII:
                    return new Degree8();
                default:
                    throw new ArgumentOutOfRangeException(nameof(degreeEnum));
            }
        }

        protected DegreeBase()
        {
        }

        public abstract DegreeEnum DegreeEnum { get; }

        public abstract string DiatonicFunction { get; }

        public abstract string CorrespondingModeMajorKey { get; }

        public abstract string CorrespondingModeMinorKey { get; }

        public abstract string Meaning { get; }

        public abstract Note NoteInCMajor{ get; }

        public abstract Note NoteInCMinor { get; }

        public int DegreeIndex
            => ((int)DegreeEnum) - 1;

        public override string ToString()
        {
            return DegreeEnum.ToString();
        }
    }
}