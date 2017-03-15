namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMinorSecond : NoteQuality
    {
        public IntervalMinorSecond(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public IntervalMinorSecond(string note)
            : base(note)
        {
        }

        public IntervalMinorSecond(Note note)
            : base(note)
        {
        }

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMinorSecond;

        public override List<string> QualityName { get; }
            = new List<string> { "Minor Second", "Semitone", "Half Tone", "Half Step" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "m2" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "min. 2" };

        public override string QualityComposition { get; }
            = "1 demi-ton diatonique";

        public override int Semitones { get; }
            = 1;

        public override NoteQuality Inverse { get; }
            = null;
    }
}