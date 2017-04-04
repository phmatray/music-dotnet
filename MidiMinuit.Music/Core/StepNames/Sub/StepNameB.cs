namespace MidiMinuit.Music.Core.StepNames
{
    public class StepNameB
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.B;

        public override int Semitones { get; }
            = 11;

        public override int MidiPitch { get; }
            = 71;

        public override int StepNumber { get; }
            = 7;

        public override string Name { get; }
            = "B";

        public override string NameLatin { get; }
            = "Si";

        public override string ToString()
            => Name;

        public override StepName Clone()
            => MemberwiseClone() as StepName;
    }
}