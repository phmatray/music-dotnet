using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.NoteAccidentals
{
    public class NoteAccidentalFactory
    {
        public virtual List<NoteAccidental> CreateAllNoteAccidentals()
        {
            return Enum.GetValues(typeof(Accidental))
                .Cast<Accidental>()
                .Select(CreateNoteAccidental)
                .ToList();
        }

        public virtual NoteAccidental CreateNoteAccidental(Accidental accidental)
        {
            switch (accidental)
            {
                case Accidental.Natural:
                    return new NoteAccidentalNatural();
                case Accidental.Flat:
                    return new NoteAccidentalFlat();
                case Accidental.Sharp:
                    return new NoteAccidentalSharp();
                case Accidental.DoubleFlat:
                    return new NoteAccidentalDoubleFlat();
                case Accidental.DoubleSharp:
                    return new NoteAccidentalDoubleSharp();
                default:
                    throw new ArgumentOutOfRangeException(nameof(accidental), accidental, null);
            }
        }
    }
}