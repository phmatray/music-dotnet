namespace MidiMinuit.Lib.Core.Intervals
{
    using System;
    using NoteNames;
    using Notes;

    //public static class NoteExtensions
    //{
    //    public static Note GetEquivalent(this Note note)
    //    {
    //        if (note.Accidental == NoteAccidental.DoubleFlat)
    //        {
    //            return new Note();
    //        }
    //    }
    //}

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
            var noteNameRepository = new NoteNameRepository();
            var upperNoteName = noteNameRepository.GetByOrder(upperNoteNameValue);

            var semitones2 = lowerNote.Pitch + interval.Semitones;
            //var repo = new NoteRepository();
            //var candidateNotes = repo.GetAllBySemitones(semitones2);

            //var upperNote = candidateNotes.Single(x => x.Name == upperNoteName);
            //return upperNote;
            return null;


            // var note = lowerNote + semitones;
            // with C## => must be G##
        }

        //public static Note GetLowerNote() { }
    }
}