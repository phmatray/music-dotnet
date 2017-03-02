
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiMinuit.Lib.Chords.Core.Scales.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Scales.Enum;

namespace MidiMinuit.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var notes = IntervalHelper.GetScale(Note.New(), ScaleType.Major);
        }
    }
}
