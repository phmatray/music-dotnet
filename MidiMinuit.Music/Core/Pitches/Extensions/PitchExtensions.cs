using System;
using MidiMinuit.Music.Core.Extensions;

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


        internal static object Create(StepName expectedPitchName, int tmpOctave, int expectedMidiPitch)
        {
            return null;
        }

        /// <summary>
        /// AddInterval is different from "pitch + interval".
        /// Use this one if you don't want to apply a pitch correction
        /// </summary>
        public static Pitch AddInterval(this Pitch startingPitch, Interval interval)
        {
            if (startingPitch == null)
            {
                throw new ArgumentNullException(nameof(startingPitch));
            }

            if (interval == null)
            {
                throw new ArgumentNullException(nameof(interval));
            }

            int expectedSteps = startingPitch.Name.StepNumber + interval.DiatonicInterval.Steps;

            int expectedPitchNameValue = (expectedSteps - 1) % 7;
            if (expectedPitchNameValue == 0)
            {
                expectedPitchNameValue = 7;
            }

            StepName expectedPitchName = expectedPitchNameValue;

            int expectedOctave = startingPitch.Octave + ((expectedSteps - 2) / 7);
            int naturalMidiPitch = expectedPitchName.GetMidiPitch(expectedOctave);
            int expectedMidiPitch = startingPitch.MidiPitch + interval.Semitones;
            int expectedCorrection = (expectedMidiPitch - naturalMidiPitch) % 7;

            StepAccidental expectedStepAccidental = expectedCorrection;

            return new Pitch(expectedPitchName, expectedStepAccidental, expectedOctave);
        }

        /// <summary>
        /// SubstractInterval is different from "pitch - interval".
        /// Use this one if you don't want to apply a pitch correction
        /// </summary>
        public static Pitch SubstractInterval(this Pitch endingPitch, Interval interval)
        {
            if (endingPitch == null)
            {
                throw new ArgumentNullException(nameof(endingPitch));
            }

            if (interval == null)
            {
                throw new ArgumentNullException(nameof(interval));
            }

            // TODO: Refaire le code de cette méthode en adaptant la méthode AddIntervel
            // peut-être qu'inverser un intervalle pourrait aider

            int endingStepNumber = endingPitch.Name.StepNumber;
            int intervalSteps = interval.DiatonicInterval.Steps;

            int startingStepNumber = endingStepNumber - intervalSteps + 1;
            while (startingStepNumber < 1)
            {
                startingStepNumber += 7;
            }

            StepName startingPitchName = startingStepNumber;
            StepAccidental stepAccidental = (endingPitch.MidiPitch - interval.Semitones) % 12;
            int octave = ((endingPitch.MidiPitch - interval.Semitones) / 12) - 1;

            return new Pitch(startingPitchName, stepAccidental, octave);
        }
    }
}