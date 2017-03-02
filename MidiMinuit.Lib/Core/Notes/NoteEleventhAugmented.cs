namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteEleventhAugmented : NoteQuality
    {
        public NoteEleventhAugmented(NoteNameEnum name = NoteNameEnum.C, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteEleventhAugmented(string note)
            : base(note)
        {
        }

        public NoteEleventhAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality => NoteQualityEnum.NoteEleventhAugmented;

        public override string RoleName => "Eleventh Augmented";

        public override string RoleAbbreviation => "NO DATA";
    }
}