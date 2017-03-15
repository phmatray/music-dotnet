namespace MidiMinuit.Lib.Core.Intervals
{
    using MidiMinuit.Lib.Core.Notes;

    public class IntervalPerfectUnison : NoteQuality
    {
        public IntervalPerfectUnison(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalPerfectUnison(string note)
            : base(note)
        {
        }

        public IntervalPerfectUnison(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalPerfectUnison;

        public override string QualityName
            => "Perfect Unison";

        public override string QualityAbbreviation
            => "P1";

        public override string QualityAbbreviation2
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones
            => 0;
    }
}