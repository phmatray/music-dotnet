using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;
using System;

namespace MidiMinuit.Music.Tests
{
    [TestClass]
    public class IntervalTests
    {
        [TestMethod]
        public void IntervalCreateWithPitches()
        {
            var interval = Interval.Create(Pitch.C4, Pitch.G4);

            Assert.AreEqual("P5", interval.Abbreviation);
            Assert.AreEqual(Pitch.C4, interval.StartingPitch);
            Assert.AreEqual(Pitch.G4, interval.EndingPitch);
        }

        [TestMethod]
        public void IntervalCreateWithPitches2()
        {
            var interval = Interval.Create(Pitch.C3, Pitch.C4);

            Assert.AreEqual("P8", interval.Abbreviation);
            Assert.AreEqual(Pitch.C3, interval.StartingPitch);
            Assert.AreEqual(Pitch.C4, interval.EndingPitch);
        }

        [TestMethod]
        public void IntervalCreateWithPitches3()
        {
            var interval = Interval.Create(Pitch.C3, Pitch.CSharp4);

            Assert.AreEqual("A8", interval.Abbreviation);
            Assert.AreEqual(Pitch.C3, interval.StartingPitch);
            Assert.AreEqual(Pitch.CSharp4, interval.EndingPitch);
        }

        [TestMethod]
        public void IntervalCreateWithPitches4()
        {
            var interval = Interval.Create(IntervalAlias.AugmentedOctave);
            interval.StartingPitch = Pitch.CSharp4;

            Assert.AreEqual("A8", interval.Abbreviation);
            Assert.AreEqual(Pitch.CSharp4, interval.StartingPitch);
            Assert.AreEqual(new Pitch("C##5"), interval.EndingPitch);
        }

        [TestMethod]
        public void IntervalCreateWithPitchesInverse()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var interval = Interval.Create(Pitch.G4, Pitch.C4);
            });
        }

        [TestMethod]
        public void IntervalPitchOperatorAddInterval()
        {
            Pitch pitch = Pitch.C4;
            IntervalPerfectFifth fifth = Interval.PerfectFifth;
            Pitch expected = pitch + fifth;

            Assert.AreEqual(Pitch.G4, expected);
        }

        [TestMethod]
        public void IntervalPitchOperatorSubstractInterval()
        {
            Pitch pitch = Pitch.G4;
            IntervalPerfectFifth fifth = Interval.PerfectFifth;
            Pitch expected = pitch - fifth;

            Assert.AreEqual(Pitch.C4, expected);
        }

        [TestMethod]
        public void IntervalPitchAddInterval()
        {
            Pitch pitch = new Pitch(StepNameAlias.C, StepAccidentalAlias.DoubleSharp);
            var octave = Interval.PerfectOctave;
            Pitch expected = pitch.AddInterval(octave);

            var left = new Pitch(StepNameAlias.C, StepAccidentalAlias.DoubleSharp, 5);
            Assert.AreEqual(left, expected);
        }

        [TestMethod]
        public void IntervalPitchSubstractInterval()
        {
            Pitch pitch = new Pitch(StepNameAlias.C, StepAccidentalAlias.DoubleSharp);
            var octave = Interval.PerfectOctave;
            Pitch expected = pitch.SubstractInterval(octave);

            var left = new Pitch(StepNameAlias.C, StepAccidentalAlias.DoubleSharp, 3);
            Assert.AreEqual(left, expected);

        }

        [TestMethod]
        public void IntervalInverseOctaveUp()
        {
            var pitch1 = Pitch.C4;
            var pitch2 = Pitch.G4;
            var interval = Interval.Create(pitch1, pitch2);

            Interval expected = interval.InverseOctaveUp();

            Assert.AreEqual(Pitch.G4, expected.StartingPitch);
            Assert.AreEqual(Pitch.C5, expected.EndingPitch);
        }

        [TestMethod]
        public void IntervalInverseOctaveUp2()
        {
            var pitch1 = Pitch.C3;
            var pitch2 = Pitch.CSharp4;
            var interval = Interval.Create(pitch1, pitch2);

            Interval expected = interval.InverseOctaveUp();

            Assert.AreEqual(Pitch.CSharp4, expected.StartingPitch);
            Assert.AreEqual(Pitch.C5, expected.EndingPitch);
        }

        [TestMethod]
        public void IntervalInverseOctaveUp3()
        {
            var interval = Interval.Create(IntervalAlias.AugmentedOctave);
            interval.StartingPitch = Pitch.CSharp4;

            Interval expected = interval.InverseOctaveUp();

            Assert.AreEqual("d8", expected.Abbreviation);
            Assert.AreEqual(Pitch.CSharp4, interval.StartingPitch);
            Assert.AreEqual(new Pitch("C##5"), interval.EndingPitch);
        }

        [TestMethod]
        public void IntervalInverseOctaveDown()
        {
            var pitch1 = Pitch.C4;
            var pitch2 = Pitch.G4;
            var interval = Interval.Create(pitch1, pitch2);

            Interval expected = interval.InverseOctaveDown();

            Assert.AreEqual(Pitch.G3, expected.StartingPitch);
            Assert.AreEqual(Pitch.C4, expected.EndingPitch);
        }

        [TestMethod]
        public void IntervalStepsDetails()
        {
            IntervalPerfectFifth fifth = new IntervalPerfectFifth(Pitch.C4);
            string expected = fifth.StepsDetails;

            Assert.AreEqual("C to G", expected);
        }

        [TestMethod]
        public void IntervalStepsDetailsOctave()
        {
            var pitch = new Pitch(StepNameAlias.C, StepAccidentalAlias.DoubleSharp);
            var octave = Interval.PerfectOctave;
            octave.StartingPitch = pitch;
            var expected = octave.StepsDetails;

            Assert.AreEqual("C## to C##", expected);
        }

        [TestMethod]
        public void IntervalStepsDetailsNull()
        {
            IntervalPerfectFifth fifth = Interval.PerfectFifth;
            string expected = fifth.StepsDetails;

            Assert.AreEqual(null, expected);
        }

        [TestMethod]
        public void IntervalPitchesDetails()
        {
            IntervalPerfectFifth fifth = new IntervalPerfectFifth(Pitch.C4);
            string expected = fifth.PitchesDetails;

            Assert.AreEqual("C4 to G4", expected);
        }

        [TestMethod]
        public void IntervalPitchesDetailsNull()
        {
            IntervalPerfectFifth fifth = Interval.PerfectFifth;
            string expected = fifth.PitchesDetails;

            Assert.AreEqual(null, expected);
        }
    }
}