using System.Collections.Generic;

namespace MidiMinuit.Music.Core
{
    public class ScalePentatonicMinor
        : Scale
    {
        private Pitch _key;

        /// <summary>
        ///     Gets Gamme Pentatonique Mineure : T 3m 4j 5j 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.PentatonicMinor;

        public Pitch Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
                Fondamental = new IntervalPerfectUnison(_key);
                ThirdMinor = new IntervalMinorThird(_key);
                FourthPerfect = new IntervalPerfectFourth(_key);
                FifthPerfect = new IntervalPerfectFifth(_key);
                SeventhMinor = new IntervalMinorSeventh(_key);
            }
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalPerfectFourth FourthPerfect { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name { get; }
            = "Pentatonic Minor";

        public override string Details { get; }
            = "T 3m 4j 5j 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}