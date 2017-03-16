namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public class Degree3 : DegreeBase
    {
        public override DegreeEnum DegreeEnum
            => DegreeEnum.III;

        public override string DiatonicFunction
            => "Mediant";

        public override string CorrespondingModeMajorKey
            => "Phrygian";

        public override string CorrespondingModeMinorKey
            => "Ionian";

        public override string Meaning
            => "Midway between tonic and dominant, (in minor key) root of relative major key";

        public override Note NoteInCMajor
            => new Note(NoteName.E);

        public override Note NoteInCMinor
            => new Note(NoteName.E, NoteAccidental.Flat);
    }
}