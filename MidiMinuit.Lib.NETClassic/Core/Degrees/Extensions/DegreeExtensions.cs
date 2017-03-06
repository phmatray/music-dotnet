namespace MidiMinuit.Lib.Core.Degrees
{
    public static class DegreeExtensions
    {
        public static string GetFunction(this DegreeEnum degree)
        {
            switch (degree)
            {
                case DegreeEnum.I:
                    return "tonique";
                case DegreeEnum.II:
                    return "sus-tonique";
                case DegreeEnum.III:
                    return "médiante";
                case DegreeEnum.IV:
                    return "sous-dominante";
                case DegreeEnum.V:
                    return "dominante";
                case DegreeEnum.VI:
                    return "sus-dominante";
                case DegreeEnum.VII:
                    return "sensible";
                case DegreeEnum.VIII:
                    return "octave";
                default:
                    return null;
            }
        }
    }
}