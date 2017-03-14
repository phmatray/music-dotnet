namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSecondAugmented : NoteQuality
    {
        public NoteSecondAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondAugmented(string note)
            : base(note)
        {
        }

        public NoteSecondAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSecondAugmented;

        public override string QualityName
            => "Second Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 ton et 1 demi-ton chromatique";

        public override int Semitones
            => 3;
    }
}