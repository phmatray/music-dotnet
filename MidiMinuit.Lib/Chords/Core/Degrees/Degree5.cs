using MidiMinuit.Lib.Chords.Core.Degrees.Base;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.Lib.Chords.Core.Degrees
{
    public class Degree5 : Degree
    {
        protected internal Degree5()
            : base()
        {
        }

        public override DegreeOrder DegreeEnum
            => DegreeOrder.V;

        public override string DiatonicFunction
            => "Dominant";

        public override string CorrespondingModeMajorKey
            => "Mixolydian";

        public override string CorrespondingModeMinorKey
            => "Phrygian";

        public override string Meaning
            => "2nd in importance to the tonic";

        public override Note NoteInCMajor
            => new Note(NoteName.G);

        public override Note NoteInCMinor
            => new Note(NoteName.G);
    }
}