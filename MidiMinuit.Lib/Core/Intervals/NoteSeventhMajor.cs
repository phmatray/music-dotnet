using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteSeventhMajor : NoteQuality
    {
        public NoteSeventhMajor(string note)
            : base(note)
        {
        }

        public NoteSeventhMajor(Note note)
            : base(note)
        {
        }

        public NoteSeventhMajor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMajorSeventh;

        public override string QualityName
            => "Seventh Major";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "5 tons et 1 demi-ton diatonique";

        public override int Semitones
            => 11;
    }
}