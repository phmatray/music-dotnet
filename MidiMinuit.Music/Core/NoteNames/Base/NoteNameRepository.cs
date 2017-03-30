using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.NoteNames
{
    public class NoteNameRepository
    {
        private readonly List<NoteName> _noteNames;

        public NoteNameRepository()
        {
            var factory = new NoteNameFactory();
            _noteNames = factory.CreateAllNoteNames();
        }

        public List<NoteName> GetAll()
            => _noteNames;

        public NoteName Get(NoteNameAlias name)
            => _noteNames
                .Single(x => x.Alias == name);

        public NoteName GetByOrder(int order)
            => _noteNames
                .Single(x => x.Order == order);

        public NoteName GetByName(string name)
            => _noteNames
                .Single(x => x.Name == name || x.NameLatin == name);
    }
}