using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core.Chords;
using MidiMinuit.Music.Core.Pitches;
using MidiMinuit.Music.Tools;

namespace MidiMinuit.UnitTestProject
{
    [TestClass]
    public class MusicContext_UnitTest
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

        [TestMethod]
        public void TestMethod2()
        {
            var chordMajor = new ChordMajor(Pitch.C4);

            var fond = chordMajor.Fondamental.UpperPitch;
            var third = chordMajor.ThirdMajor.UpperPitch;
            var fifth = chordMajor.FifthPerfect.UpperPitch;

            Assert.AreEqual(Pitch.C4, fond);
            Assert.AreEqual(Pitch.E4, third);
            Assert.AreEqual(Pitch.G4, fifth);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var chordMajor = new ChordMajor { Key = Pitch.C4 };

            var fond = chordMajor.Fondamental.UpperPitch;
            var third = chordMajor.ThirdMajor.UpperPitch;
            var fifth = chordMajor.FifthPerfect.UpperPitch;

            Assert.AreEqual(Pitch.C4, fond);
            Assert.AreEqual(Pitch.E4, third);
            Assert.AreEqual(Pitch.G4, fifth);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Chord chordMajor = Chord.Major.SetKey(Pitch.C4);

            var fond = chordMajor.Intervals[0].UpperPitch;
            var third = chordMajor.Intervals[1].UpperPitch;
            var fifth = chordMajor.Intervals[2].UpperPitch;

            Assert.AreEqual(Pitch.C4, fond);
            Assert.AreEqual(Pitch.E4, third);
            Assert.AreEqual(Pitch.G4, fifth);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Type chordMajor = Chord.Major.GetType();

            Assert.AreEqual(typeof(ChordMajor), chordMajor);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var chordMajor = new ChordMajor(Pitch.C4);

            var fond = chordMajor.Fondamental.UpperPitch;
            var result = fond == Pitch.C4;

            Assert.AreEqual(true, result);
        }
    }
}
