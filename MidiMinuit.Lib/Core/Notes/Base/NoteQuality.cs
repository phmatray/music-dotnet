namespace MidiMinuit.Lib.Core.Notes
{
    using MidiMinuit.Lib.Core.Intervals;
    using System.Collections.Generic;

    public abstract class NoteQuality : Note
    {
        protected NoteQuality(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        protected NoteQuality(string note)
            : base(note)
        {
        }

        protected NoteQuality(Note note)
            : base(note)
        {
        }

        public abstract IntervalQualityEnum Quality { get; }

        public abstract List<string> QualityName { get; }

        public abstract List<string> QualityAbbreviation { get; }

        public abstract List<string> QualityAbbreviation2 { get; }

        public abstract string QualityComposition { get; }

        public abstract int Semitones { get; }

        public abstract NoteQuality Inverse { get; }
    }
}