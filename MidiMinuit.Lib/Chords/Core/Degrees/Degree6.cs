using MidiMinuit.Lib.Chords.Core.Degrees.Base;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.Lib.Chords.Core.Degrees
{
    public class Degree6 : Degree
    {
        protected internal Degree6()
            : base()
        {
        }

        public override DegreeOrder DegreeEnum
            => DegreeOrder.VI;

        public override string DiatonicFunction
            => "Submediant";

        public override string CorrespondingModeMajorKey
            => "Aeolian";

        public override string CorrespondingModeMinorKey
            => "Lydian";

        public override string Meaning
            => "Lower mediant, midway between tonic and subdominant, (in major key) root of relative minor key";

        public override Note NoteInCMajor
            => new Note(NoteName.A);

        public override Note NoteInCMinor
            => new Note(NoteName.A, NoteAccidental.Flat);
    }
}