using System.Collections.Generic;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleBlues
        : Scale
    {
        private Pitch _key;

        /// <summary>
        ///     Gets Gamme Blues : T 3m 4j b5 5j 7m
        /// </summary>
        public override ScaleAlias Alias { get; }
            = ScaleAlias.Blues;

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
                FifthDiminished = new IntervalDiminishedFifth(_key);
                FifthPerfect = new IntervalPerfectFifth(_key);
                SeventhMinor = new IntervalMinorSeventh(_key);
            }
        }

        public IntervalPerfectUnison Fondamental { get; private set; }

        public IntervalMinorThird ThirdMinor { get; private set; }

        public IntervalPerfectFourth FourthPerfect { get; private set; }

        public IntervalDiminishedFifth FifthDiminished { get; private set; }

        public IntervalPerfectFifth FifthPerfect { get; private set; }

        public IntervalMinorSeventh SeventhMinor { get; private set; }

        public override List<Interval> Notes
            => new List<Interval>
            {
                Fondamental,
                ThirdMinor,
                FourthPerfect,
                FifthDiminished,
                FifthPerfect,
                SeventhMinor
            };

        public override string Name { get; }
            = "Blues";

        public override string Details { get; }
            = "T 3m 4j b5 5j 7m";

        public override string ToString()
            => Name;

        public override Scale Clone()
            => MemberwiseClone() as Scale;
    }
}