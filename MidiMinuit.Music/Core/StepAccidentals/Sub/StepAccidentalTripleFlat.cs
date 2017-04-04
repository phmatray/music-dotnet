namespace MidiMinuit.Music.Core.StepAccidentals
{
    public class StepAccidentalTripleFlat
        : StepAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.TripleFlat;

        public override int Value { get; }
            = -3;

        public override string Name { get; }
            = "Triple Flat";

        public override string SignUnicode { get; }
            = "♭♭♭";

        public override string SignAscii { get; }
            = "bbb";

        public override string ToString()
            => SignUnicode;

        public override StepAccidental Clone()
            => MemberwiseClone() as StepAccidental;
    }
}