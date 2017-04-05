using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.UnitTestProject
{
    [TestClass]
    public class MusicContextTests
    {
        [TestMethod]
        public void MusicContextIntervalsSemitones5()
        {
            var context = MusicContext.Intervals
                .Where(x => x.Semitones == 5)
                .ToList();

            var count = context.Count;

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void MusicContextStepAccidentalsSingleNatural()
        {
            StepAccidental accidental = MusicContext.StepAccidentals
                .Single(x => x.SignAscii == "");

            Assert.AreEqual("", accidental.SignAscii);
            Assert.AreEqual("", accidental.SignUnicode);
            Assert.AreEqual(StepAccidentalAlias.Natural, accidental.Alias);
            Assert.AreEqual(0, accidental.Value);
            Assert.AreEqual("Natural", accidental.Name);
        }
    }
}
