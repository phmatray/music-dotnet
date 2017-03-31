namespace MidiMinuit.Music.Core.NoteAccidentals
{
    public class StepAccidentalNatural
        : StepAccidental
    {
        public override NoteAccidentalAlias Alias { get; }
            = NoteAccidentalAlias.Natural;

        public override int Value { get; }
            = 0;

        public override string Name { get; }
            = "Natural";

        public override string SignUnicode { get; }
            = string.Empty;

        public override string SignAscii { get; }
            = string.Empty;

        public override string ToString()
            => SignUnicode;

        public override StepAccidental Clone()
            => MemberwiseClone() as StepAccidental;
    }
}