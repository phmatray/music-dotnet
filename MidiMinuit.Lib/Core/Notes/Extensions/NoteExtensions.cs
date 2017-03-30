namespace MidiMinuit.Lib.Core.Notes
{
    using Intervals;
    using NoteAccidentals;
    using NoteNames;

    public static class NoteExtensions
    {
        public static Pitch AddInterval(this Pitch lowerPitch, Interval interval)
        {
            var lowerNoteOrder = lowerPitch.Name.Order;
            var intervalOrder = interval.Number.Order;

            var upperNoteOrder = lowerNoteOrder + intervalOrder - 1;
            while (upperNoteOrder > 7)
            {
                upperNoteOrder -= 7;
            }

            var noteNameRepo = new NoteNameRepository();
            var upperNoteName = noteNameRepo.GetByOrder(upperNoteOrder);
            var upperNotePitch = lowerPitch.PitchAbsolute + interval.Semitones;

            var accidentalCorrection = upperNotePitch - upperNoteName.Value;
            while (accidentalCorrection >= 8)
            {
                accidentalCorrection -= 12;
            }

            var accidentalRepo = new NoteAccidentalRepository();
            var noteAccidental = accidentalRepo.Get(accidentalCorrection);

            var upperNote = new Pitch(upperNoteName, noteAccidental);
            return upperNote;
        }
    }
}