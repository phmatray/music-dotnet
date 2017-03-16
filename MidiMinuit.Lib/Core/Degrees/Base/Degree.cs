namespace MidiMinuit.Lib.Core.Degrees
{
    using Notes;

    public abstract class Degree
    {
        protected Degree()
        {
        }

        public abstract DegreeNumberEnum Number { get; }

        public abstract string DiatonicFunction { get; }

        public abstract string CorrespondingModeMajorKey { get; }

        public abstract string CorrespondingModeMinorKey { get; }

        public abstract string Meaning { get; }

        public abstract string Function { get; }

        public abstract Note NoteInCMajor { get; }

        public abstract Note NoteInCMinor { get; }

        public int DegreeIndex
            => ((int)Number) - 1;

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}