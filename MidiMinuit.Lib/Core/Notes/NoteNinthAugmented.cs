namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteNinthAugmented : NoteQuality
    {
        public NoteNinthAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteNinthAugmented(string note)
            : base(note)
        {
        }

        public NoteNinthAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteNinthAugmented;

        public override string QualityName
            => "Ninth Augmented";

        public override string QualityAbbreviation
            => "NO DATA";
    }
}