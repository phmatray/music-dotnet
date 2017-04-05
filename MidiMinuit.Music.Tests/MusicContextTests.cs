using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.UnitTestProject
{
    [TestClass]
    public class MusicContextTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = MusicContext.Intervals
                .Where(x => x.Semitones == 5)
                .ToList();

            var count = context.Count;

            Assert.AreEqual(2, count);
        }
    }
}
