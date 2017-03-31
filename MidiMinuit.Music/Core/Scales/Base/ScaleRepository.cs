using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.Scales
{
    public class ScaleRepository
    {
        private readonly List<Scale> _scales;

        public ScaleRepository()
        {
            var factory = new ScaleFactory();
            _scales = factory.CreateAllScales();
        }

        public List<Scale> GetAll()
            => _scales;

        public Scale Get(ScaleAlias scale)
            => _scales
                .Single(x => x.Alias == scale);
    }
}