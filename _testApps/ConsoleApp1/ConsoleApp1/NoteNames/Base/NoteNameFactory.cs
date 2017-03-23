using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.NoteNames
{
    public class NoteNameFactory
    {
        public virtual List<NoteName> CreateAllNoteNames()
        {
            return Enum.GetValues(typeof(NoteNameAlias))
                .Cast<NoteNameAlias>()
                .Select(CreateNoteName)
                .ToList();
        }

        public virtual NoteName CreateNoteName(NoteNameAlias name)
        {
            switch (name)
            {
                case NoteNameAlias.C:
                    return new NoteNameC();
                case NoteNameAlias.D:
                    return new NoteNameD();
                case NoteNameAlias.E:
                    return new NoteNameE();
                case NoteNameAlias.F:
                    return new NoteNameF();
                case NoteNameAlias.G:
                    return new NoteNameG();
                case NoteNameAlias.A:
                    return new NoteNameA();
                case NoteNameAlias.B:
                    return new NoteNameB();
                default:
                    throw new ArgumentOutOfRangeException(nameof(name), name, null);
            }
        }
    }
}