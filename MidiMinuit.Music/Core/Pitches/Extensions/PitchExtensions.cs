namespace MidiMinuit.Music.Core
{
    public static class PitchExtensions
    {
        public static Chord ToChord(this Pitch pitch, ChordAlias chordAlias)
        {
            var chord = Chord.Create(chordAlias);
            chord.Key = pitch;
            return chord;
        }

        public static Scale ToScale(this Pitch pitch, ScaleAlias scaleAlias)
        {
            var scale = Scale.Create(scaleAlias);
            scale.Key = pitch;
            return scale;
        }

        ////[Obsolete("User 'lowerPitch + interval' instead.")]
        ////public static Pitch AddInterval(this Pitch lowerPitch, Interval interval)
        ////{
        ////    var lowerPitchOrder = lowerPitch.Name.StepNumber;
        ////    var intervalOrder = interval.IntervalStep.Steps;

        ////    var upperPitchOrder = lowerPitchOrder + intervalOrder - 1;
        ////    while (upperPitchOrder > 7)
        ////    {
        ////        upperPitchOrder -= 7;
        ////    }

        ////    StepName upperPitchName = upperPitchOrder;
        ////    int upperPitchValue = lowerPitch.PitchAbsolute + interval.Semitones;

        ////    int accidentalCorrection = upperPitchValue - upperPitchName.Semitones;
        ////    while (accidentalCorrection >= 8)
        ////    {
        ////        accidentalCorrection -= 12;
        ////    }

        ////    StepAccidental stepAccidental = accidentalCorrection;

        ////    var upperPitch = new Pitch(upperPitchName, stepAccidental);
        ////    return upperPitch;
        ////}

        ////[Obsolete("User 'upperPitch + interval' instead.")]
        ////public static Pitch SubstractInterval(this Pitch upperPitch, Interval interval)
        ////{
        ////    var upperPitchOrder = upperPitch.Name.StepNumber;
        ////    var intervalOrder = interval.IntervalStep.Steps;

        ////    var lowerPitchOrder = upperPitchOrder - intervalOrder + 1;
        ////    while (lowerPitchOrder < 7)
        ////    {
        ////        lowerPitchOrder += 7;
        ////    }

        ////    StepName lowerPitchName = lowerPitchOrder;
        ////    int lowerPitchValue = upperPitch.PitchAbsolute - interval.Semitones;

        ////    int accidentalCorrection = lowerPitchValue + lowerPitchName.Semitones;
        ////    while (accidentalCorrection < 8)
        ////    {
        ////        accidentalCorrection += 12;
        ////    }

        ////    StepAccidental stepAccidental = accidentalCorrection;

        ////    var lowerPitch = new Pitch(lowerPitchName, stepAccidental);
        ////    return lowerPitch;
        ////}
    }
}