using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;
using MidiMinuit.Music.Core.Extensions;

namespace MidiMinuit.Music.Tests
{
    [TestClass]
    public class StepNameTests
    {
        [TestMethod]
        public void StepNameGetMidiPitchC()
        {
            var stepName = StepName.C;
            var expected = stepName.GetMidiPitch(4);
            Assert.AreEqual(60, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchD()
        {
            var stepName = StepName.D;
            var expected = stepName.GetMidiPitch(4);
            Assert.AreEqual(62, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchE()
        {
            var stepName = StepName.E;
            var expected = stepName.GetMidiPitch(4);
            Assert.AreEqual(64, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchF()
        {
            var stepName = StepName.F;
            var expected = stepName.GetMidiPitch(4);
            Assert.AreEqual(65, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchG()
        {
            var stepName = StepName.G;
            var expected = stepName.GetMidiPitch(4);
            Assert.AreEqual(67, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchA()
        {
            var stepName = StepName.A;
            var expected = stepName.GetMidiPitch(4);
            Assert.AreEqual(69, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchB()
        {
            var stepName = StepName.B;
            var expected = stepName.GetMidiPitch(4);
            Assert.AreEqual(71, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchNull()
        {
            StepNameB stepName = null;
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var expected = StepNameExtensions.GetMidiPitch(stepName, 4);
            });
        }

        [TestMethod]
        public void StepNameGetMidiPitchOctaveLowerBound()
        {
            var stepName = StepName.C;
            var expected = stepName.GetMidiPitch(-1);
            Assert.AreEqual(0, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchOctaveUpperBound()
        {
            var stepName = StepName.G;
            var expected = stepName.GetMidiPitch(9);
            Assert.AreEqual(127, expected);
        }

        [TestMethod]
        public void StepNameGetMidiPitchOctaveLowerBoundOutOfRange()
        {
            var stepName = StepName.B;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                var expected = stepName.GetMidiPitch(-2);
            });
        }

        [TestMethod]
        public void StepNameGetMidiPitchOctaveUpperBoundOutOfRange()
        {
            var stepName = StepName.A;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                var expected = stepName.GetMidiPitch(9);
            });
        }

        [TestMethod]
        public void StepNameGetMidiPitchOctaveNegative()
        {
            var stepName = StepName.B;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                var expected = stepName.GetMidiPitch(-4);
            });
        }
    }
}