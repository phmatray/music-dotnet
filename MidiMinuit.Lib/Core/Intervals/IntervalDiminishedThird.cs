namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalDiminishedThird : NoteQuality
    {
        public IntervalDiminishedThird(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalDiminishedThird(string note)
            : base(note)
        {
        }

        public IntervalDiminishedThird(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalDiminishedThird;

        public override List<string> QualityName { get; }
            = new List<string> { "Diminished Third" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "d3", "°3" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "deg. 3", "dim. 3" };

        public override string QualityComposition { get; }
            = "2 demi-tons diatoniques";

        public override int Semitones { get; }
            = 2;

        public override NoteQuality Inverse { get; }
            = null;
    }
}