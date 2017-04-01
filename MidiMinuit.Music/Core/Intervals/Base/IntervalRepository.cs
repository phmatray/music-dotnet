using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.IntervalNumbers;

namespace MidiMinuit.Music.Core.Intervals
{
    public class IntervalRepository
    {
        private readonly List<Interval> _intervals;

        public IntervalRepository()
        {
            var factory = new IntervalFactory();
            // TODO: fix this
            ////_intervals = factory.CreateAllIntervals();
        }

        public List<Interval> GetAll()
            => _intervals;

        public List<Interval> GetByNumber(IntervalStep step)
            => _intervals
                .Where(x => x.Step == step)
                .ToList();

        public List<Interval> GetByModifier(IntervalModifier modifier)
            => _intervals
                .Where(x => x.Modifier == modifier)
                .ToList();

        public List<Interval> GetBySpanning(IntervalSpanning spanning)
            => _intervals
                .Where(x => x.Spanning == spanning)
                .ToList();

        public List<Interval> GetByAbbreviation(string abbreviation)
            => _intervals
                .Where(x => x.Abbreviations.First() == abbreviation)
                .ToList();

        public List<Interval> GetBySemitones(int semitones)
            => _intervals
                .Where(x => x.Semitones == semitones)
                .ToList();

        public Interval Get(IntervalAlias interval)
            => _intervals
                .Single(x => x.Alias == interval);
    }
}