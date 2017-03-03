namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFourthAugmented : NoteQuality
    {
        public NoteFourthAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthAugmented(string note)
            : base(note)
        {
        }

        public NoteFourthAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteFourthAugmented;

        public override string QualityName
            => "Fourth Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 tons, 1 demi-ton diatonique et 1 demi-ton chromatique ou 3 tons(Triton)";
    }
}