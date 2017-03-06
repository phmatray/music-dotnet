namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteFourthPerfect : NoteQuality
    {
        public NoteFourthPerfect(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteFourthPerfect(string note)
            : base(note)
        {
        }

        public NoteFourthPerfect(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteFourthPerfect;

        public override string QualityName
            => "Fourth Perfect";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "2 tons et 1 demi-ton diatonique";
    }
}