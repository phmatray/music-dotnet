namespace MidiMinuit.Music.Core
{
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

            StepName upperNoteName = upperNoteOrder;
            var upperNotePitch = lowerPitch.PitchAbsolute + interval.Semitones;

            var accidentalCorrection = upperNotePitch - upperNoteName.Semitones;
            while (accidentalCorrection >= 8)
            {
                accidentalCorrection -= 12;
            }

            StepAccidental noteAccidental = accidentalCorrection;

            var upperNote = new Pitch(upperNoteName, noteAccidental);
            return upperNote;
        }
    }
}