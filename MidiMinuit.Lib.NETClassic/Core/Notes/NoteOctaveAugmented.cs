namespace MidiMinuit.Lib.Core.Notes
{
    public class NoteOctaveAugmented : NoteQuality
    {
        public NoteOctaveAugmented(NoteNameEnum name, NoteAccidentalEnum accidental = NoteAccidentalEnum.Natural)
            : base(name, accidental)
        {
        }

        public NoteOctaveAugmented(string note)
            : base(note)
        {
        }

        public NoteOctaveAugmented(Note note)
            : base(note)
        {
        }

        public override NoteQualityEnum Quality
            => NoteQualityEnum.NoteOctaveAugmented;

        public override string QualityName
            => "Octave Augmented";

        public override string QualityAbbreviation
            => "NO DATA";

        public override string QualityComposition
            => "5 tons, 2 demi-tons diatoniques et 1 demi-ton chromatique";
    }
}