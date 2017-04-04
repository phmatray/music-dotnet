namespace MidiMinuit.Music.Core.StepAccidentals
{
    public partial class StepAccidental
    {
        public static StepAccidental Natural
            => Create(NoteAccidentalAlias.Natural);

        public static StepAccidental Flat
            => Create(NoteAccidentalAlias.Flat);

        public static StepAccidental Sharp
            => Create(NoteAccidentalAlias.Sharp);

        public static StepAccidental DoubleFlat
            => Create(NoteAccidentalAlias.DoubleFlat);

        public static StepAccidental DoubleSharp
            => Create(NoteAccidentalAlias.DoubleSharp);

        public static StepAccidental TripleFlat
            => Create(NoteAccidentalAlias.TripleFlat);

        public static StepAccidental TripleSharp
            => Create(NoteAccidentalAlias.TripleSharp);

        public static StepAccidental QuadrupleFlat
            => Create(NoteAccidentalAlias.QuadrupleFlat);

        public static StepAccidental QuadrupleSharp
            => Create(NoteAccidentalAlias.QuadrupleSharp);
    }
}