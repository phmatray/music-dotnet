namespace MidiMinuit.Music.Core
{
    public class StepNameC
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.C;

        public override int Semitones { get; }
            = 0;

        public override int StepNumber { get; }
            = 1;

        public override string Name { get; }
            = "C";

        public override string NameLatin { get; }
            = "Do";

        public override string ToString()
            => Name;
    }
}