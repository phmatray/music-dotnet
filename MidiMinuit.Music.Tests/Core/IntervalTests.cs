using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Music.Tests
{
    [TestClass]
    public class IntervalTests
    {
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

            Assert.AreEqual(Pitch.C4, interval1.LowerPitch);
            Assert.AreEqual(Pitch.G4, interval1.UpperPitch);
            Assert.AreEqual(Pitch.G4, interval2.LowerPitch);
            Assert.AreEqual(Pitch.C4, interval2.UpperPitch);
        }
    }
}