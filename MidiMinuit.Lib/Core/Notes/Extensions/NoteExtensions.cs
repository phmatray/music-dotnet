namespace MidiMinuit.Lib.Core.Notes
{
    using Intervals;
    using NoteAccidentals;
    using NoteNames;

    public static class NoteExtensions
    {
        public static Note AddInterval(this Note lowerNote, Interval interval)
        {
            var lowerNoteOrder = lowerNote.Name.Order;
            var intervalOrder = interval.Number.Order;

            var upperNoteOrder = lowerNoteOrder + intervalOrder - 1;
            while (upperNoteOrder > 7)
            {
                upperNoteOrder -= 7;
            }

            var noteNameRepo = new NoteNameRepository();
            var upperNoteName = noteNameRepo.GetByOrder(upperNoteOrder);
            var upperNotePitch = lowerNote.Pitch + interval.Semitones;

            var accidentalCorrection = upperNotePitch - upperNoteName.Value;
            while (accidentalCorrection >= 8)
            {
                accidentalCorrection -= 12;
            }

            var accidentalRepo = new NoteAccidentalRepository();
            var noteAccidental = accidentalRepo.Get(accidentalCorrection);

            var upperNote = new Note(upperNoteName, noteAccidental);
            return upperNote;
        }
    }
}