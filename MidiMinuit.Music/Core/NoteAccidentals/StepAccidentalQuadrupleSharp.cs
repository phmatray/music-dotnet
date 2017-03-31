namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class StepAccidentalQuadrupleSharp
        : StepAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.QuadrupleSharp;

        public override int Value { get; }
            = 4;

        public override string Name { get; }
            = "Quadruple Sharp";

        public override string SignUnicode { get; }
            = "♯♯♯♯";

        public override string SignAscii { get; }
            = "####";

        public override string ToString()
            => SignUnicode;

        public override StepAccidental Clone()
            => MemberwiseClone() as StepAccidental;
    }
}