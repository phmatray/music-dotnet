using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.NoteAccidentals
{
    public class NoteAccidentalRepository
    {
        private readonly List<NoteAccidental> _noteAccidentals;

        public NoteAccidentalRepository()
        {
            var factory = new NoteAccidentalFactory();
            _noteAccidentals = factory.CreateAllNoteAccidentals();
        }

        public List<NoteAccidental> GetAll()
            => _noteAccidentals;

        public NoteAccidental Get(Accidental accidental)
            => _noteAccidentals
                .Single(x => x.Accidental == accidental);

        public NoteAccidental Get(int accidentalValue)
            => _noteAccidentals
                .Single(x => x.Accidental == (Accidental)accidentalValue);

        public NoteAccidental GetBySymbol(string symbol)
            => _noteAccidentals
                .Single(x => x.Symbol == symbol || x.Symbol2 == symbol);
    }
}