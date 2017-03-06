using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Degrees
{
    public class Degree7 : DegreeBase
    {
        public override DegreeEnum DegreeEnum
            => DegreeEnum.VII;

        public override string DiatonicFunction
            => "Leading tone(in Major scale) / Subtonic (in Natural Minor Scale)";

        public override string CorrespondingModeMajorKey
            => "Locrian";

        public override string CorrespondingModeMinorKey
            => "Mixolydian";

        public override string Meaning
            => "Melodically strong affinity for and leads to tonic/One half step below tonic in Major scale and whole step in Natural minor.";

        public override Note NoteInCMajor
            => new Note(NoteNameEnum.B);

        public override Note NoteInCMinor
            => new Note(NoteNameEnum.B, NoteAccidentalEnum.Flat);
    }
}