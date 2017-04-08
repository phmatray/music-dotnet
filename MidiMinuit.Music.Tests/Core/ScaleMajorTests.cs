using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Music.Tests
{
    [TestClass]
    public class ScaleTests
    {
        [TestMethod]
        public void ScalePitchToScale()
        {
            var scaleMajor = Pitch.C4.ToScale(ScaleAlias.Major);

            Assert.AreEqual(Pitch.C4, scaleMajor.Fondamental.EndingPitch);
            Assert.AreEqual(Pitch.D4, scaleMajor.MajorSecond.EndingPitch);
            Assert.AreEqual(Pitch.E4, scaleMajor.MajorThird.EndingPitch);
            Assert.AreEqual(Pitch.F4, scaleMajor.PerfectFourth.EndingPitch);
            Assert.AreEqual(Pitch.G4, scaleMajor.PerfectFifth.EndingPitch);
            Assert.AreEqual(Pitch.A4, scaleMajor.MajorSixth.EndingPitch);
            Assert.AreEqual(Pitch.B4, scaleMajor.MajorSeventh.EndingPitch);
        }

        [TestMethod]
        public void ScalePitchToScaleG4()
        {
            var scaleMajor = Pitch.G4.ToScale(ScaleAlias.Major);

            Assert.AreEqual(Pitch.G4, scaleMajor.Fondamental.EndingPitch);
            Assert.AreEqual(Pitch.A4, scaleMajor.MajorSecond.EndingPitch);
            Assert.AreEqual(Pitch.B4, scaleMajor.MajorThird.EndingPitch);
            Assert.AreEqual(Pitch.C5, scaleMajor.PerfectFourth.EndingPitch);
            Assert.AreEqual(Pitch.D5, scaleMajor.PerfectFifth.EndingPitch);
            Assert.AreEqual(Pitch.E5, scaleMajor.MajorSixth.EndingPitch);
            Assert.AreEqual(Pitch.FSharp5, scaleMajor.MajorSeventh.EndingPitch);
        }

        [TestMethod]
        public void ScaleGetDetails()
        {
            ScaleMajor scaleMajor = Scale.Major;
            scaleMajor.Key = Pitch.C4;

            string expected = scaleMajor.IntervalDetails;

            Assert.AreEqual("P1 - M2 - M3 - P4 - P5 - M6 - M7", expected);
        }
    }
}