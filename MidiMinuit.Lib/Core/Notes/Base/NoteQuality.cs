using MidiMinuit.Lib.Core.Intervals;

namespace MidiMinuit.Lib.Core.Notes
{
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

        public abstract string QualityName { get; }

        public abstract string QualityAbbreviation { get; }

        public abstract string QualityComposition { get; }

        public abstract int Semitones { get; }
    }
}