using MidiMinuit.Lib.Chords.Core.Degrees.Base;
using MidiMinuit.Lib.Chords.Core.Degrees.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.Lib.Chords.Core.Degrees
{
    public class Degree7 : Degree
    {
        protected internal Degree7()
            : base()
        {
        }

        public override DegreeOrder DegreeEnum
            => DegreeOrder.VII;

        public override string DiatonicFunction
            => "Leading tone(in Major scale) / Subtonic (in Natural Minor Scale)";

        public override string CorrespondingModeMajorKey
            => "Locrian";

        public override string CorrespondingModeMinorKey
            => "Mixolydian";

        public override string Meaning
            => "Melodically strong affinity for and leads to tonic/One half step below tonic in Major scale and whole step in Natural minor.";

        public override Note NoteInCMajor
            => new Note(NoteName.B);

        public override Note NoteInCMinor
            => new Note(NoteName.B, NoteAccidental.Flat);
    }
}