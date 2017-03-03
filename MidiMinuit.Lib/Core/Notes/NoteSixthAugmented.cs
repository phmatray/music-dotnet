namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSixthAugmented : NoteQuality
    {
        public NoteSixthAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSixthAugmented(string note)
            : base(note)
        {
        }

        public NoteSixthAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSixthAugmented;

        public override string QualityName
            => "Sixth Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "4 tons, 1 demi-ton diatonique et 1 demi-ton chromatique";
    }
}