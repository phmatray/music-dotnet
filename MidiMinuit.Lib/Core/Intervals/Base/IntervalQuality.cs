namespace MidiMinuit.Lib.Core.Intervals
{
    using System.Collections.Generic;
    using Notes;
    using Tools;

    public abstract class IntervalQuality
    {
        ////protected IntervalQuality(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
        ////    : base(name, accidental)
        ////{
        ////}

        ////protected IntervalQuality(string note)
        ////    : base(note)
        ////{
        ////}

        ////protected IntervalQuality(Note note)
        ////    : base(note)
        ////{
        ////}

        public abstract IntervalSpanningEnum Spanning { get; }

        public abstract IntervalQualityEnum Quality { get; }

        public abstract List<string> QualityName { get; }

        public abstract List<string> QualityAbbreviation { get; }

        public abstract List<string> QualityAbbreviation2 { get; }

        public abstract string QualityComposition { get; }

        public abstract int Semitones { get; }

        /// <summary>
        /// Gets the interval class
        /// An interval class is the shortest distance in pitch class space between two unordered pitch classes.
        /// </summary>
        /// <returns>The interval class</returns>
        public int IntervalClass
            => MusicMathFormulaHelpers.InvervalClass(Semitones);
    }
}