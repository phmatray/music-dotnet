using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Music.Core.Pitches;
using MidiMinuit.Music.Core.StepAccidentals;
using MidiMinuit.Music.Core.StepNames;
using MidiMinuit.Music.Core.Steps;

namespace MidiMinuit.UnitTestProject
{
    [TestClass]
    public class Pitch_UnitTest
    {
        [TestMethod]
        public void Pitch_Ctor1()
        {
            var fromStep = Pitch.FromStep(Step.C, 4);

            Assert.AreEqual(StepName.C, fromStep.Name);
            Assert.AreEqual(StepAccidental.Natural, fromStep.Accidental);
            Assert.AreEqual(4, fromStep.Octave);
        }
    }
}