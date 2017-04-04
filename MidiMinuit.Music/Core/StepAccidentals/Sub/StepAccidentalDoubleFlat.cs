namespace MidiMinuit.Music.Core.StepAccidentals
{
    public class StepAccidentalDoubleFlat
        : StepAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.DoubleFlat;

        public override int Value { get; }
            = -2;

        public override string Name { get; }
            = "Double Flat";

        public override string SignUnicode { get; }
            = "♭♭";

        public override string SignAscii { get; }
            = "bb";

        public override string ToString()
            => SignUnicode;

        public override StepAccidental Clone()
            => MemberwiseClone() as StepAccidental;
    }
}