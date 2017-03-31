////using System.Collections.Generic;
////using System.Linq;
////using MidiMinuit.Music.Core.Notes;

////namespace MidiMinuit.Music.Core.Scales
////{
////    public class ScaleRepository
////    {
////        private readonly List<Scale> _scales;

////        public ScaleRepository()
////        {
////            var factory = new ScaleFactory();
////            _scales = factory.CreateAllScales();
////        }

////        public List<Scale> GetAll(Pitch key)
////            => new ScaleFactory().CreateAllScales(key);

////        public Scale Get(ScaleAlias scale)
////            => new ScaleFactory().CreateAllScales(key)
////                .Single(x => x.Alias == scale);
////    }
////}