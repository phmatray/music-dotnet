namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteThirdMinor : NoteQuality
    {
        public NoteThirdMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteThirdMinor(string note)
            : base(note)
        {
        }

        public NoteThirdMinor(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteThirdMinor;

        public override string QualityName
            => "Third Minor";

        public override string QualityAbbreviation
            => "3ʳᵈ min";

        public override string QualityComposition
            => "1 ton et 1 demi-ton diatonique";

        public override int Semitones
            => 3;
    }
}