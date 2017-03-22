using System;
using MidiMinuit.Lib.Core.Notes;

namespace ConsoleApp1.Intervals
{
    public static class NoteExtensions
    {
        public static Note GetEquivalent(this Note note)
        {
            if (note.Accidental == NoteAccidental.DoubleFlat)
            {
                return new Note();
            }
        }
    }

    public static class IntervalExtensions
    {
        public static Note GetUpperNote(Note lowerNote, Interval interval)
        {
            if (lowerNote == null)
            {
                throw new ArgumentNullException(nameof(lowerNote));
            }

            if (interval == null)
            {
                throw new ArgumentNullException(nameof(interval));
            }

            // Note upperNote = lowerNote + interval;
            // Note upperNote = lowerNote.Add(interval);

            var semitones = interval.Semitones;
            var upperNoteNameValue = (lowerNote.Name.Order + interval.IntervalClass) % 8;


            var note = lowerNote + semitones;
            // with C## => must be G##



            //var upperNoteAccidental = 


            //var upperNote = new Note


            // interval.Number.Value
            //lowerNote.Name.Value

            return null;
        }

        //public static Note GetLowerNote() { }
    }
}