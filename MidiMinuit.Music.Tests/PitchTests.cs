namespace MidiMinuit.UnitTestProject
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Music.Core.Pitches;
    using Music.Core.StepAccidentals;
    using Music.Core.StepNames;
    using Music.Core.Steps;

    [TestClass]
    public class PitchTests
    {
        [TestMethod]
        public void Pitch_FromStep1()
        {
            var fromStep = Pitch.FromStep(Step.C, 4);

            Assert.AreEqual(StepName.C, fromStep.Name);
            Assert.AreEqual(StepAccidental.Natural, fromStep.Accidental);
            Assert.AreEqual(4, fromStep.Octave);
            Assert.AreEqual(60, fromStep.MidiPitch);
        }

        [TestMethod]
        public void Pitch_FromStep2()
        {
            var fromStep = Pitch.FromStep(Step.CSharp, 3);

            Assert.AreEqual(StepName.C, fromStep.Name);
            Assert.AreEqual(StepAccidental.Sharp, fromStep.Accidental);
            Assert.AreEqual(3, fromStep.Octave);
            Assert.AreEqual(49, fromStep.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Ctor1()
        {
            var pitch = new Pitch("C", 1, 4);

            Assert.AreEqual(StepName.C, pitch.Name);
            Assert.AreEqual(StepAccidental.Sharp, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(61, pitch.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Ctor2()
        {
            var pitch = new Pitch(StepNameAlias.D, NoteAccidentalAlias.DoubleFlat, 3);

            Assert.AreEqual(StepName.D, pitch.Name);
            Assert.AreEqual(StepAccidental.DoubleFlat, pitch.Accidental);
            Assert.AreEqual(3, pitch.Octave);
            Assert.AreEqual(48, pitch.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Ctor3()
        {
            Pitch pitch = new Pitch("D#4");

            Assert.AreEqual(StepName.D, pitch.Name);
            Assert.AreEqual(StepAccidental.Sharp, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(63, pitch.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Implicite1()
        {
            var s = "D#4";
            Pitch pitch = s;

            Assert.AreEqual(StepName.D, pitch.Name);
            Assert.AreEqual(StepAccidental.Sharp, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(63, pitch.MidiPitch);
        }

        [TestMethod]
        public void Pitch_Implicite2()
        {
            PitchAlias alias = PitchAlias.E4;
            Pitch pitch = alias;

            Assert.AreEqual(StepName.E, pitch.Name);
            Assert.AreEqual(StepAccidental.Natural, pitch.Accidental);
            Assert.AreEqual(4, pitch.Octave);
            Assert.AreEqual(64, pitch.MidiPitch);
        }
    }
}