namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSeventhAugmented : NoteQuality
    {
        public NoteSeventhAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSeventhAugmented(string note)
            : base(note)
        {
        }

        public NoteSeventhAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteSeventhAugmented;

        public override string QualityName
            => "Seventh Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "Inusitée dans la pratique";
    }
}