namespace OpenJam.Music.Core
{
    public class StepNameF
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.F;

        public override int Semitones { get; }
            = 5;

        public override int StepNumber { get; }
            = 4;

        public override string Name { get; }
            = "F";

        public override string NameLatin { get; }
            = "Fa";

        public override string ToString()
            => Name;
    }
}