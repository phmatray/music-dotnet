using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Tests
{
    [TestClass]
    public class PitchTests
    {
        [TestMethod]
        public void Pitch_FromStep1()
        {
            var fromStep = Pitch.FromStep(Step.C, 4);

            Assert.AreEqual(StepName.C, fromStep.Name);
            Assert.AreEqual(StepAccidental.Natural, fromStep.Accidental);
            Assert.AreEqual(4, fromStep.Octave);
            Assert.AreEqual(60, fromStep.MidiPitch);
        }

        [TestMethod]
        public void Pitch_FromStep2()
        {
            var fromStep = Pitch.FromStep(Step.CSharp, 3);

            Assert.AreEqual(StepName.C, fromStep.Name);
            Assert.AreEqual(StepAccidental.Sharp, fromStep.Accidental);
            Assert.AreEqual(3, fromStep.Octave);
            Assert.AreEqual(49, fromStep.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Ctor1()
        {
            var pitch = new Pitch("C", 1, 4);

            Assert.AreEqual(StepName.C, pitch.Name);
            Assert.AreEqual(StepAccidental.Sharp, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(61, pitch.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Ctor2()
        {
            var pitch = new Pitch(StepNameAlias.D, StepAccidentalAlias.DoubleFlat, 3);

            Assert.AreEqual(StepName.D, pitch.Name);
            Assert.AreEqual(StepAccidental.DoubleFlat, pitch.Accidental);
            Assert.AreEqual(3, pitch.Octave);
            Assert.AreEqual(48, pitch.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Ctor3()
        {
            Pitch pitch = new Pitch("D#4");

            Assert.AreEqual(StepName.D, pitch.Name);
            Assert.AreEqual(StepAccidental.Sharp, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(63, pitch.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Implicite1()
        {
            var s = "D#4";
            Pitch pitch = s;

            Assert.AreEqual(StepName.D, pitch.Name);
            Assert.AreEqual(StepAccidental.Sharp, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(63, pitch.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Implicite2()
        {
            PitchAlias alias = PitchAlias.E4;
            Pitch pitch = alias;

            Assert.AreEqual(StepName.E, pitch.Name);
            Assert.AreEqual(StepAccidental.Natural, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(64, pitch.MidiPitch);
        }

        [TestMethod]
        public void PitchToStringCb2()
        {
            Pitch pitch = Pitch.Cb2;
            string expectedResult = pitch.ToString();
            Assert.AreEqual("Cb2", expectedResult);
        }

        [TestMethod]
        public void PitchStepDistanceC4G4()
        {
            var pitch1 = Pitch.C4;
            var pitch2 = Pitch.G4;

            var expected = Pitch.StepDistance(pitch1, pitch2);

            Assert.AreEqual(5, expected);
        }

        [TestMethod]
        public void PitchStepDistanceG4C5()
        {
            var pitch1 = Pitch.G4;
            var pitch2 = Pitch.C5;

            var expected = Pitch.StepDistance(pitch1, pitch2);

            Assert.AreEqual(4, expected);
        }

        [TestMethod]
        public void PitchAddInterval()
        {
            Pitch startingPitch = new Pitch(StepNameAlias.C, StepAccidentalAlias.DoubleFlat); 
            Interval interval = new IntervalDiminishedSecond();

            Pitch expected = startingPitch.AddInterval(interval);
            Assert.AreEqual(new Pitch(StepNameAlias.D, StepAccidentalAlias.QuadrupleFlat), expected);
        }

        [TestMethod]
        public void PitchAddInterval2()
        {
            Pitch startingPitch = new Pitch(StepNameAlias.F, StepAccidentalAlias.DoubleSharp, 4); 
            Interval interval = new IntervalAugmentedOctave();

            Pitch expected = startingPitch.AddInterval(interval);
            Assert.AreEqual(new Pitch(StepNameAlias.F, StepAccidentalAlias.TripleSharp, 5), expected);
        }

        [TestMethod]
        public void PitchAddInterval3()
        {
            Pitch startingPitch = Pitch.C4; 
            Interval interval = new IntervalPerfectFifth();

            Pitch expected = startingPitch.AddInterval(interval);
            Assert.AreEqual(Pitch.G4, expected);
        }

        [TestMethod]
        public void PitchAddInterval4()
        {
            Pitch startingPitch = Pitch.C4; 
            Interval interval = new IntervalMajorSixth();

            Pitch expected = startingPitch.AddInterval(interval);
            Assert.AreEqual(Pitch.A4, expected);
        }

        [TestMethod]
        public void PitchAddInterval5()
        {
            Pitch startingPitch = Pitch.E4; 
            Interval interval = new IntervalPerfectFifth();

            Pitch expected = startingPitch.AddInterval(interval);
            Assert.AreEqual(Pitch.B4, expected);
        }
    }
}