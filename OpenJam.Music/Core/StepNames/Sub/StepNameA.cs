namespace OpenJam.Music.Core
{
    public class StepNameA
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.A;

        public override int Semitones { get; }
            = 9;

        public override int StepNumber { get; }
            = 6;

        public override string Name { get; }
            = "A";

        public override string NameLatin { get; }
            = "La";

        public override string ToString()
            => Name;
    }
}