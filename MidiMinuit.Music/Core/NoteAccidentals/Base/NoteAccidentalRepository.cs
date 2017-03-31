using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class NoteAccidentalRepository
    {
        private readonly List<StepAccidental> _noteAccidentals;

        public NoteAccidentalRepository()
        {
            var factory = new NoteAccidentalFactory();
            _noteAccidentals = factory.CreateAllNoteAccidentals();
        }

        public List<StepAccidental> GetAll()
            => _noteAccidentals;

        public StepAccidental Get(NoteAccidentalAlias accidental)
            => _noteAccidentals
                .Single(x => x.Alias == accidental);

        public StepAccidental Get(int accidentalValue)
            => _noteAccidentals
                .Single(x => x.Value == accidentalValue);

        public StepAccidental GetBySymbol(string symbol)
            => _noteAccidentals
                .Single(x => x.SignUnicode == symbol || x.SignAscii == symbol);
    }
}