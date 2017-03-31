using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.NoteNames
{
    public class StepNameRepository
    {
        private readonly List<StepName> _noteNames;

        public StepNameRepository()
        {
            var factory = new StepNameFactory();
            _noteNames = factory.CreateAllNoteNames();
        }

        public List<StepName> GetAll()
            => _noteNames;

        public StepName Get(StepNameAlias name)
            => _noteNames
                .Single(x => x.Alias == name);

        public StepName GetByOrder(int order)
            => _noteNames
                .Single(x => x.StepNumber == order);

        public StepName GetByName(string name)
            => _noteNames
                .Single(x => x.Name == name || x.NameLatin == name);
    }
}