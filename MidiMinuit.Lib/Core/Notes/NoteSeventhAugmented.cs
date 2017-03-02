namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteSeventhAugmented : NoteQuality
    {
        public NoteSeventhAugmented(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
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

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteSeventhAugmented;

        public override string RoleName => "Seventh Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}