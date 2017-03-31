namespace MidiMinuit.Lib.NoteAccidentals
{
    using System.Collections.Generic;
    using System.Linq;

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

        public NoteAccidental Get(NoteAccidentalAlias accidental)
            => _noteAccidentals
                .Single(x => x.Alias == accidental);

        public NoteAccidental Get(int accidentalValue)
            => _noteAccidentals
                .Single(x => x.Alias == (NoteAccidentalAlias)accidentalValue);

        public NoteAccidental GetBySymbol(string symbol)
            => _noteAccidentals
                .Single(x => x.Symbol == symbol || x.Symbol2 == symbol);
    }
}