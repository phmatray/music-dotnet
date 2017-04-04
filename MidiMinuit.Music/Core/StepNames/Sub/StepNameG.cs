namespace MidiMinuit.Music.Core.StepNames
{
    public class StepNameG
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.G;

        public override int Semitones { get; }
            = 7;

        public override int MidiPitch { get; }
            = 67;

        public override int StepNumber { get; }
            = 5;

        public override string Name { get; }
            = "G";

        public override string NameLatin { get; }
            = "Sol";

        public override string ToString()
            => Name;

        public override StepName Clone()
            => MemberwiseClone() as StepName;
    }
}