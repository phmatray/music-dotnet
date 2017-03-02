using MidiMinuit.Lib.Chords.Core.Degrees.Base;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.Lib.Chords.Core.Degrees
{
    public class Degree4 : Degree
    {
        protected internal Degree4()
            : base()
        {
        }

        public override DegreeOrder DegreeEnum
            => DegreeOrder.IV;

        public override string DiatonicFunction
            => "Subdominant";

        public override string CorrespondingModeMajorKey
            => "Lydian";

        public override string CorrespondingModeMinorKey
            => "Dorian";

        public override string Meaning
            => "Lower dominant, same interval below tonic as dominant is above tonic";

        public override Note NoteInCMajor
            => new Note(NoteName.F);

        public override Note NoteInCMinor
            => new Note(NoteName.F);
    }
}