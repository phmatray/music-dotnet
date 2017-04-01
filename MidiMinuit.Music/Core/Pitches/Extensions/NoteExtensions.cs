using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.NoteAccidentals;
using MidiMinuit.Music.Core.NoteNames;

namespace MidiMinuit.Music.Core.Notes
{
    public static class NoteExtensions
    {
        public static Pitch AddInterval(this Pitch lowerPitch, Interval interval)
        {
            var lowerNoteOrder = lowerPitch.Name.StepNumber;
            var intervalOrder = interval.Step.Steps;

            var upperNoteOrder = lowerNoteOrder + intervalOrder - 1;
            while (upperNoteOrder > 7)
            {
                upperNoteOrder -= 7;
            }

            var noteNameRepo = new StepNameRepository();
            var upperNoteName = noteNameRepo.GetByOrder(upperNoteOrder);
            var upperNotePitch = lowerPitch.PitchAbsolute + interval.Semitones;

            var accidentalCorrection = upperNotePitch - upperNoteName.Semitones;
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