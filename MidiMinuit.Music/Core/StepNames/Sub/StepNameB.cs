namespace MidiMinuit.Music.Core
{
    public class StepNameB
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.B;

        public override int Semitones { get; }
            = 11;

        public override int StepNumber { get; }
            = 7;

        public override string Name { get; }
            = "B";

        public override string NameLatin { get; }
            = "Si";

        public override string ToString()
            => Name;
    }
}