using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.IntervalModifiers;
using ConsoleApp1.Intervals;

namespace ConsoleApp1.IntervalQualities
{
    public class IntervalRepository
    {
        private readonly List<Interval> _intervals;

        public IntervalRepository()
        {
            var factory = new IntervalFactory();
            _intervals = factory.CreateAllIntervals();
        }

        public List<Interval> GetAll()
            => _intervals;

        public List<Interval> GetByNumber(IntervalNumber number)
            => _intervals
                .Where(x => x.Number == number)
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
                .Where(x => x.QualityAbbreviation.First() == abbreviation)
                .ToList();

        public List<Interval> GetBySemitones(int semitones)
            => _intervals
                .Where(x => x.Semitones == semitones)
                .ToList();

        public Interval Get(IntervalQuality quality)
            => _intervals
                .Single(x => x.Quality == quality);
    }
}