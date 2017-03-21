using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.IntervalNumbers
{
    public class IntervalNumberRepository
    {
        private readonly List<IntervalNumber> _intervalNumbers;

        public IntervalNumberRepository()
        {
            var factory = new IntervalNumberFactory();
            _intervalNumbers = factory.CreateAllIntervalNumbers();
        }

        public List<IntervalNumber> GetAll()
            => _intervalNumbers;

        public List<IntervalNumber> GetByAbbreviation(string abbreviation)
            => _intervalNumbers
                .Where(x => x.Abbreviation == abbreviation)
                .ToList();

        public IntervalNumber Get(Number number)
            => _intervalNumbers
                .Single(x => x.Number == number);

        public IntervalNumber Get(int number)
            => _intervalNumbers
                .Single(x => x.Number == (Number)number);
    }
}