namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class StepAccidentalQuadrupleFlat
        : StepAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.QuadrupleFlat;

        public override int Value { get; }
            = -4;

        public override string Name { get; }
            = "Quadruple Flat";

        public override string SignUnicode { get; }
            = "♭♭♭♭";

        public override string SignAscii { get; }
            = "bbbb";

        public override string ToString()
            => SignUnicode;

        public override StepAccidental Clone()
            => MemberwiseClone() as StepAccidental;
    }
}