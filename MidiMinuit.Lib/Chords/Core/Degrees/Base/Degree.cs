using System;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Degrees.Base
{
    public abstract class Degree
    {
        public static Degree GetDegree(DegreeOrder degreeEnum)
        {
            switch (degreeEnum)
            {
                case DegreeOrder.I:
                    return new Degree1();
                case DegreeOrder.II:
                    return new Degree2();
                case DegreeOrder.III:
                    return new Degree3();
                case DegreeOrder.IV:
                    return new Degree4();
                case DegreeOrder.V:
                    return new Degree5();
                case DegreeOrder.VI:
                    return new Degree6();
                case DegreeOrder.VII:
                    return new Degree7();
                case DegreeOrder.VIII:
                    return new Degree8();
                default:
                    throw new ArgumentOutOfRangeException(nameof(degreeEnum));
            }
        }

        protected Degree()
        {
        }

        public abstract DegreeOrder DegreeEnum { get; }

        public abstract string DiatonicFunction { get; }

        public abstract string CorrespondingModeMajorKey { get; }

        public abstract string CorrespondingModeMinorKey { get; }

        public abstract string Meaning { get; }

        public abstract Note NoteInCMajor{ get; }

        public abstract Note NoteInCMinor { get; }

        public override string ToString()
        {
            return DegreeEnum.ToString();
        }
    }






    public static class DegreeHelper
    {
        public static string GetFunction(this DegreeOrder degree)
        {
            switch (degree)
            {
                case DegreeOrder.I:
                    return "tonique";
                case DegreeOrder.II:
                    return "sus-tonique";
                case DegreeOrder.III:
                    return "médiante";
                case DegreeOrder.IV:
                    return "sous-dominante";
                case DegreeOrder.V:
                    return "dominante";
                case DegreeOrder.VI:
                    return "sus-dominante";
                case DegreeOrder.VII:
                    return "sensible";
                case DegreeOrder.VIII:
                    return "octave";
                default:
                    return null;
            }
        }
    }
}