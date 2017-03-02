using MidiMinuit.Lib.Chords.Core.Degrees.Base;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.Lib.Chords.Core.Degrees
{
    public class Degree2 : Degree
    {
        protected internal Degree2()
            : base()
        {
        }

        public override DegreeOrder DegreeEnum
            => DegreeOrder.II;

        public override string DiatonicFunction
            => "Supertonic";

        public override string CorrespondingModeMajorKey
            => "Dorian";

        public override string CorrespondingModeMinorKey
            => "Locrian";

        public override string Meaning
            => "One whole step above the tonic";

        public override Note NoteInCMajor
            => new Note(NoteName.D);

        public override Note NoteInCMinor
            => new Note(NoteName.D);
    }
}