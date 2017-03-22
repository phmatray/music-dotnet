using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.NoteNames
{
    public class NoteNameFactory
    {
        public virtual List<NoteName> CreateAllNoteNames()
        {
            return Enum.GetValues(typeof(Name))
                .Cast<Name>()
                .Select(CreateNoteName)
                .ToList();
        }

        public virtual NoteName CreateNoteName(Name name)
        {
            switch (name)
            {
                case Name.C:
                    return new NoteNameC();
                case Name.D:
                    return new NoteNameD();
                case Name.E:
                    return new NoteNameE();
                case Name.F:
                    return new NoteNameF();
                case Name.G:
                    return new NoteNameG();
                case Name.A:
                    return new NoteNameA();
                case Name.B:
                    return new NoteNameB();
                default:
                    throw new ArgumentOutOfRangeException(nameof(name), name, null);
            }
        }
    }
}