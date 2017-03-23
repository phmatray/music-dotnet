using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.NoteAccidentals
{
    public class NoteAccidentalFactory
    {
        public virtual List<NoteAccidental> CreateAllNoteAccidentals()
        {
            return Enum.GetValues(typeof(NoteAccidentalAlias))
                .Cast<NoteAccidentalAlias>()
                .Select(CreateNoteAccidental)
                .ToList();
        }

        public virtual NoteAccidental CreateNoteAccidental(NoteAccidentalAlias accidental)
        {
            switch (accidental)
            {
                case NoteAccidentalAlias.Natural:
                    return new NoteAccidentalNatural();
                case NoteAccidentalAlias.Flat:
                    return new NoteAccidentalFlat();
                case NoteAccidentalAlias.Sharp:
                    return new NoteAccidentalSharp();
                case NoteAccidentalAlias.DoubleFlat:
                    return new NoteAccidentalDoubleFlat();
                case NoteAccidentalAlias.DoubleSharp:
                    return new NoteAccidentalDoubleSharp();
                default:
                    throw new ArgumentOutOfRangeException(nameof(accidental), accidental, null);
            }
        }
    }
}