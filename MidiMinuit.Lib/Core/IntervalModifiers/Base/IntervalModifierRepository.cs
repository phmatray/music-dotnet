namespace MidiMinuit.Lib.Core.IntervalModifiers
{
    using System.Collections.Generic;
    using System.Linq;

    public class IntervalModifierRepository
    {
        private readonly List<IntervalModifier> _intervalModifiers;

        public IntervalModifierRepository()
        {
            var factory = new IntervalModifierFactory();
            _intervalModifiers = factory.CreateAllIntervalModifiers();
        }

        public List<IntervalModifier> GetAll()
            => _intervalModifiers;

        public List<IntervalModifier> GetByAbbreviation(string abbreviation)
            => _intervalModifiers
                .Where(x => x.Abbreviation == abbreviation)
                .ToList();

        public IntervalModifier Get(IntervalModifierAlias modifier)
            => _intervalModifiers
                .Single(x => x.Alias == modifier);
    }
}