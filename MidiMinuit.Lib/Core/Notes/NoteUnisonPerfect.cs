namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteUnisonPerfect : NoteQuality
    {
        public NoteUnisonPerfect(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteUnisonPerfect(string note)
            : base(note)
        {
        }

        public NoteUnisonPerfect(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteUnison;

        public override string QualityName
            => "Unison Perfect";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones
            => 0;
    }
}