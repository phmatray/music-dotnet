namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;

    public class IntervalMajorNinth : IntervalQualityCompound
    {
        ////public IntervalMajorNinth(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////public IntervalMajorNinth(string note)
        ////    : base(note)
        ////{
        ////}

        ////public IntervalMajorNinth(Note note)
        ////    : base(note)
        ////{
        ////}

        public override IntervalSpanningEnum Spanning { get; }
            = IntervalSpanningEnum.Compound;

        public override IntervalQualityEnum Quality { get; }
            = IntervalQualityEnum.IntervalMajorNinth;

        public override List<string> QualityName { get; }
            = new List<string> { "Major Ninth" };

        public override List<string> QualityAbbreviation { get; }
            = new List<string> { "M9" };

        public override List<string> QualityAbbreviation2 { get; }
            = new List<string> { "Maj. 9" };

        public override string QualityComposition { get; }
            = "NO DATA";

        public override int Semitones { get; }
            = 14;
    }
}