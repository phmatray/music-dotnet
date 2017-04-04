using MidiMinuit.Music.Core.StepAccidentals;
using MidiMinuit.Music.Core.StepNames;

namespace MidiMinuit.Music.Core.Pitches
{
    using Intervals;

    public static class PitchExtensions
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

            var upperNoteName = StepNameRepository.GetByOrder(upperNoteOrder);
            var upperNotePitch = lowerPitch.PitchAbsolute + interval.Semitones;

            var accidentalCorrection = upperNotePitch - upperNoteName.Semitones;
            while (accidentalCorrection >= 8)
            {
                accidentalCorrection -= 12;
            }

            var noteAccidental = StepAccidentalRepository.Get(accidentalCorrection);

            var upperNote = new Pitch(upperNoteName, noteAccidental);
            return upperNote;
        }
    }
}