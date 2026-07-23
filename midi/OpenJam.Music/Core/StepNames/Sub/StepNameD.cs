namespace OpenJam.Music.Core
{
    public class StepNameD
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.D;

        public override int Semitones { get; }
            = 2;

        public override int StepNumber { get; }
            = 2;

        public override string Name { get; }
            = "D";

        public override string NameLatin { get; }
            = "Ré";

        public override string ToString()
            => Name;
    }
}