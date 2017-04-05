using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.Music.Tests
{
    [TestClass]
    public class MusicContextTests
    {
        [TestMethod]
        public void MusicContextIntervalsSemitones5()
        {
            var intervals = MusicContext.Intervals
                .Count(x => x.Semitones == 5);

            Assert.AreEqual(2, intervals);
        }

        [TestMethod]
        public void MusicContextStepsCountNatural()
        {
            var steps = MusicContext.Steps
                .Count(x => x.Accidental == StepAccidental.Natural);

            Assert.AreEqual(7, steps);
        }

        [TestMethod]
        public void MusicContextStepsCountSharp()
        {
            var steps = MusicContext.Steps
                .Count(x => x.Accidental == StepAccidental.Sharp);

            Assert.AreEqual(7, steps);
        }

        [TestMethod]
        public void MusicContextStepsCountFlat()
        {
            var steps = MusicContext.Steps
                .Count(x => x.Accidental == StepAccidental.Flat);

            Assert.AreEqual(7, steps);
        }

        [TestMethod]
        public void MusicContextDegreesCreateAll()
        {
            var degrees = MusicContext.Degrees;

            Assert.AreNotEqual(null, degrees);
            Assert.AreEqual(8, degrees.Count);
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

        [TestMethod]
        public void MusicContextStepAccidentalsSingleNatural2()
        {
            StepAccidental accidental = MusicContext.StepAccidentals
                .Single(x => x.Name == "Natural");

            Assert.AreEqual("", accidental.SignAscii);
            Assert.AreEqual("", accidental.SignUnicode);
            Assert.AreEqual(StepAccidentalAlias.Natural, accidental.Alias);
            Assert.AreEqual(0, accidental.Value);
            Assert.AreEqual("Natural", accidental.Name);
        }

        [TestMethod]
        public void MusicContextStepAccidentalsSingleNatural3()
        {
            StepAccidental accidental = MusicContext.StepAccidentals
                .SingleOrDefault(x => x.Name == "natural");

            Assert.AreEqual(null, accidental);
        }
    }
}
