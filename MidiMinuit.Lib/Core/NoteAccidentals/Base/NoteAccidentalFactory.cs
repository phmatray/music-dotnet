namespace MidiMinuit.Lib.Core.NoteAccidentals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NoteAccidentalFactory
    {
        public List<NoteAccidental> CreateAllNoteAccidentals()
        {
            return Enum.GetValues(typeof(NoteAccidentalAlias))
                .Cast<NoteAccidentalAlias>()
                .Select(CreateNoteAccidental)
                .ToList();
        }

        public NoteAccidental CreateNoteAccidental(NoteAccidentalAlias accidental)
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
                case NoteAccidentalAlias.TripleFlat:
                    return new NoteAccidentalTripleFlat();
                case NoteAccidentalAlias.TripleSharp:
                    return new NoteAccidentalTripleSharp();
                case NoteAccidentalAlias.QuadrupleFlat:
                    return new NoteAccidentalQuadrupleFlat();
                case NoteAccidentalAlias.QuadrupleSharp:
                    return new NoteAccidentalQuadrupleSharp();
                default:
                    throw new ArgumentOutOfRangeException(nameof(accidental), accidental, null);
            }
        }
    }
}