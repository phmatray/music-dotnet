using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Intervals
{
    public class NoteNinthMinor : NoteQuality
    {
        public NoteNinthMinor(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteNinthMinor(string note)
            : base(note)
        {
        }

        public NoteNinthMinor(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality
            => IntervalQualityEnum.IntervalMinorNinth;

        public override string QualityName
            => "Ninth Minor";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "NO DATA";

        public override int Semitones { get; }
    }
}