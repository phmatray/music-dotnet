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
            var pitch = Pitch.C4;
            var scaleMajor = pitch.ToScale(ScaleAlias.Major);

            ////var fond = scale.Fondamental.UpperPitch;
            ////var third = scale.MajorThird.UpperPitch;
            ////var fifth = scale.PerfectFifth.UpperPitch;

            ////Assert.AreEqual(Pitch.C4, fond);
            ////Assert.AreEqual(Pitch.E4, third);
            ////Assert.AreEqual(Pitch.G4, fifth);
        }

    }
}