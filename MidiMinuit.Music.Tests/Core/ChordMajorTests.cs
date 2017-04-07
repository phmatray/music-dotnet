using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Music.Tests
{
    [TestClass]
    public class ChordMajorTests
    {
        [TestMethod]
        public void TestMethod2()
        {
            var chordMajor = new ChordMajor(Pitch.C4);

            var fond = chordMajor.Fondamental.UpperPitch;
            var third = chordMajor.MajorThird.UpperPitch;
            var fifth = chordMajor.PerfectFifth.UpperPitch;

            Assert.AreEqual(Pitch.C4, fond);
            Assert.AreEqual(Pitch.E4, third);
            Assert.AreEqual(Pitch.G4, fifth);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var chordMajor = new ChordMajor { Key = Pitch.C4 };

            var fond = chordMajor.Fondamental.UpperPitch;
            var third = chordMajor.MajorThird.UpperPitch;
            var fifth = chordMajor.PerfectFifth.UpperPitch;

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
        public void ChordMajorChangeKey()
        {
            ChordMajor chordMajor = Chord.Major;
            chordMajor.SetKey(Pitch.E4);
            chordMajor.SetKey(Pitch.C4);

            var fond = chordMajor.Intervals[0].UpperPitch;
            var third = chordMajor.Intervals[1].UpperPitch;
            var fifth = chordMajor.Intervals[2].UpperPitch;

            Assert.AreEqual(Pitch.C4, fond);
            Assert.AreEqual(Pitch.E4, third);
            Assert.AreEqual(Pitch.G4, fifth);
        }

        [TestMethod]
        public void ChordMajorIntervalDetails()
        {
            ChordMajor chordMajor = Chord.Major.SetKey(Pitch.C4);
            var expected = chordMajor.IntervalDetails;

            Assert.AreEqual("P1 - M3 - P5", expected);
        }

        [TestMethod]
        public void ChordMajorIntervalDetailsNull()
        {
            ChordMajor chordMajor = Chord.Major;
            var expected = chordMajor.IntervalDetails;

            Assert.AreEqual("P1 - M3 - P5", expected);
        }

        [TestMethod]
        public void ChordMajorStepsDetails()
        {
            ChordMajor chordMajor = Chord.Major.SetKey(Pitch.C4);
            var expected = chordMajor.StepsDetails;

            Assert.AreEqual("C - E - G", expected);
        }

        [TestMethod]
        public void ChordMajorStepsDetailsNull()
        {
            ChordMajor chordMajor = Chord.Major;
            var expected = chordMajor.StepsDetails;

            Assert.AreEqual(null, expected);
        }

        [TestMethod]
        public void ChordMajorDetails()
        {
            ChordMajor chordMajor = Chord.Major.SetKey(Pitch.C4);
            var expected = chordMajor.Details;

            Assert.AreEqual("C (P1) - E (M3) - G (P5)", expected);
        }

        [TestMethod]
        public void ChordMajorDetailsNull()
        {
            ChordMajor chordMajor = Chord.Major;
            var expected = chordMajor.Details;

            Assert.AreEqual("P1 - M3 - P5", expected);
        }

        [TestMethod]
        public void ChordMajorAbbreviation()
        {
            ChordMajor chordMajor = Chord.Major.SetKey(Pitch.C4);
            var expected = chordMajor.Abbreviation;

            Assert.AreEqual("C maj", expected);
        }

        [TestMethod]
        public void ChordMajorAbbreviationNull()
        {
            ChordMajor chordMajor = Chord.Major;
            var expected = chordMajor.Abbreviation;

            Assert.AreEqual(null, expected);
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

        [TestMethod]
        public void ChordPitchToChord()
        {
            var pitch = Pitch.C4;
            var chordMajor = pitch.ToChord(ChordAlias.Major);

            var fond = chordMajor.Fondamental.UpperPitch;
            var third = chordMajor.MajorThird.UpperPitch;
            var fifth = chordMajor.PerfectFifth.UpperPitch;

            Assert.AreEqual(Pitch.C4, fond);
            Assert.AreEqual(Pitch.E4, third);
            Assert.AreEqual(Pitch.G4, fifth);
        }
    }
}