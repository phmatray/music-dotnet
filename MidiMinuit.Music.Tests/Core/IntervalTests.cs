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
        public void IntervalCreateWithPitchiesInverse()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var interval = Interval.Create(Pitch.G4, Pitch.C4);
            });
        }

        [TestMethod]
        public void IntervalPitchAddInterval()
        {
            Pitch pitch = Pitch.C4;
            IntervalPerfectFifth fifth = Interval.PerfectFifth;
            Pitch expected = pitch + fifth;

            Assert.AreEqual(Pitch.G4, expected);
        }

        [TestMethod]
        public void IntervalPitchSubstractInterval()
        {
            Pitch pitch = Pitch.G4;
            IntervalPerfectFifth fifth = Interval.PerfectFifth;
            Pitch expected = pitch - fifth;

            Assert.AreEqual(Pitch.C4, expected);
        }

        [TestMethod]
        public void IntervalMakeDescending()
        {
            var interval1 = new IntervalPerfectFifth(Pitch.C4);
            var interval2 = interval1.MakeDescending();

            Assert.AreEqual(Pitch.C4, interval1.StartingPitch);
            Assert.AreEqual(Pitch.G4, interval1.EndingPitch);
            Assert.AreEqual(Pitch.G4, interval2.StartingPitch);
            Assert.AreEqual(Pitch.C4, interval2.EndingPitch);
        }

        [TestMethod]
        public void IntervalStepsDetails()
        {
            IntervalPerfectFifth fifth = new IntervalPerfectFifth(Pitch.C4);
            string expected = fifth.StepsDetails;

            Assert.AreEqual("C to G", expected);
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