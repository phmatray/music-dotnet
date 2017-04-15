namespace MidiMinuit.Music.Core
{
    public partial class DiatonicInterval
    {
        public static DiatonicIntervalUnison Unison
            => new DiatonicIntervalUnison();

        public static DiatonicIntervalSecond Second
            => new DiatonicIntervalSecond();

        public static DiatonicIntervalThird Third
            => new DiatonicIntervalThird();

        public static DiatonicIntervalFourth Fourth
            => new DiatonicIntervalFourth();

        public static DiatonicIntervalFifth Fifth
            => new DiatonicIntervalFifth();

        public static DiatonicIntervalSixth Sixth
            => new DiatonicIntervalSixth();

        public static DiatonicIntervalSeventh Seventh
            => new DiatonicIntervalSeventh();

        public static DiatonicIntervalOctave Octave
            => new DiatonicIntervalOctave();

        public static DiatonicIntervalNinth Ninth
            => new DiatonicIntervalNinth();

        public static DiatonicIntervalEleventh Eleventh
            => new DiatonicIntervalEleventh();

        public static DiatonicIntervalThirteenth Thirteenth
            => new DiatonicIntervalThirteenth();
    }
}