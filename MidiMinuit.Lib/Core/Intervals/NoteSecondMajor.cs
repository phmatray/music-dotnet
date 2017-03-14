using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteSecondMajor : NoteQuality
    {
        public NoteSecondMajor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteSecondMajor(string note)
            : base(note)
        {
        }

        public NoteSecondMajor(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSecond;

        public override string QualityName
            => "Second Major";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "1 ton";

        public override int Semitones
            => 2;
    }
}