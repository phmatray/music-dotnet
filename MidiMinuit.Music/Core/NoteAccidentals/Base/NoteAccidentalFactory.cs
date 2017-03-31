using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class NoteAccidentalFactory
    {
        public List<StepAccidental> CreateAllNoteAccidentals()
        {
            return Enum.GetValues(typeof(NoteAccidentalAlias))
                .Cast<NoteAccidentalAlias>()
                .Select(CreateNoteAccidental)
                .ToList();
        }

        public StepAccidental CreateNoteAccidental(NoteAccidentalAlias accidental)
        {
            switch (accidental)
            {
                case NoteAccidentalAlias.Natural:
                    return new StepAccidentalNatural();
                case NoteAccidentalAlias.Flat:
                    return new StepAccidentalFlat();
                case NoteAccidentalAlias.Sharp:
                    return new StepAccidentalSharp();
                case NoteAccidentalAlias.DoubleFlat:
                    return new StepAccidentalDoubleFlat();
                case NoteAccidentalAlias.DoubleSharp:
                    return new StepAccidentalDoubleSharp();
                case NoteAccidentalAlias.TripleFlat:
                    return new StepAccidentalTripleFlat();
                case NoteAccidentalAlias.TripleSharp:
                    return new StepAccidentalTripleSharp();
                case NoteAccidentalAlias.QuadrupleFlat:
                    return new StepAccidentalQuadrupleFlat();
                case NoteAccidentalAlias.QuadrupleSharp:
                    return new StepAccidentalQuadrupleSharp();
                default:
                    throw new ArgumentOutOfRangeException(nameof(accidental), accidental, null);
            }
        }
    }
}