using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.IntervalNumbers
{
    public class IntervalStepRepository
    {
        private readonly List<IntervalStep> _intervalNumbers;

        public IntervalStepRepository()
        {
            var factory = new IntervalStepFactory();
            _intervalNumbers = factory.CreateAllIntervalNumbers();
        }

        public List<IntervalStep> GetAll()
            => _intervalNumbers;

        public List<IntervalStep> GetByAbbreviation(string abbreviation)
            => _intervalNumbers
                .Where(x => x.Abbreviation == abbreviation)
                .ToList();

        public IntervalStep Get(IntervalStepAlias step)
            => _intervalNumbers
                .Single(x => x.Alias == step);

        public IntervalStep Get(int number)
            => _intervalNumbers
                .Single(x => x.Alias == (IntervalStepAlias)number);
    }
}