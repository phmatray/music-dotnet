using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Music.Tests
{
    [TestClass]
    public class StepTests
    {
        [TestMethod]
        public void StepCtor1()
        {
            var step = new Step("C", 1);

            Assert.AreEqual(StepName.C, step.Name);
            Assert.AreEqual(StepAccidental.Sharp, step.Accidental);
        }

        [TestMethod]
        public void StepCtor2()
        {
            var step = new Step(StepNameAlias.C, StepAccidentalAlias.TripleFlat);

            Assert.AreEqual(StepName.C, step.Name);
            Assert.AreEqual(StepAccidental.TripleFlat, step.Accidental);
        }

        [TestMethod]
        public void StepCtor3()
        {
            var step = new Step("C#");

            Assert.AreEqual(StepName.C, step.Name);
            Assert.AreEqual(StepAccidental.Sharp, step.Accidental);
        }

        [TestMethod]
        public void StepFromPitchCSharp4()
        {
            Pitch cSharp4 = Pitch.CSharp4;
            Step step = Step.FromPitch(cSharp4);
            Assert.AreEqual(StepName.C, step.Name);
            Assert.AreEqual(StepAccidental.Sharp, step.Accidental);
        }

        [TestMethod]
        public void StepFromPitchBbb4()
        {
            Pitch bbb4 = new Pitch(StepNameAlias.B, StepAccidentalAlias.DoubleFlat);
            Step step = Step.FromPitch(bbb4);
            Assert.AreEqual(StepName.B, step.Name);
            Assert.AreEqual(StepAccidental.DoubleFlat, step.Accidental);
        }

        [TestMethod]
        public void StepToPitchCSharp4()
        {
            Step step = Step.CSharp;
            Pitch pitch = step.ToPitch(4);
            Assert.AreEqual(StepName.C, pitch.Name);
            Assert.AreEqual(StepAccidental.Sharp, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(61, pitch.MidiPitch);
        }

        [TestMethod]
        public void StepToStringCSharp()
        {
            Step step = Step.CSharp;
            string expectedResult = step.ToString();
            Assert.AreEqual("C#", expectedResult);
        }

        [TestMethod]
        public void StepToStringCb()
        {
            Step step = Step.Cb;
            string expectedResult = step.ToString();
            Assert.AreEqual("Cb", expectedResult);
        }

        [TestMethod]
        public void StepToStringPitchCb2()
        {
            Step step = Pitch.Cb2;
            string expectedResult = step.ToString();
            Assert.AreNotEqual("Cb", expectedResult);
        }

        [TestMethod]
        public void StepToStringPitchCb22()
        {
            Step step = new Step(StepNameAlias.C, StepAccidentalAlias.Flat);
            string expectedResult = step.ToString();
            Assert.AreEqual("Cb", expectedResult);
        }
    }
}