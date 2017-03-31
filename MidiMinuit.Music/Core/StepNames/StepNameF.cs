namespace MidiMinuit.Music.Core.NoteNames
{
    public class StepNameF
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.F;

        public override int Semitones { get; }
            = 5;

        public override int MidiPitch { get; }
            = 65;

        public override int StepNumber { get; }
            = 4;

        public override string Name { get; }
            = "F";

        public override string NameLatin { get; }
            = "Fa";

        public override string ToString()
            => Name;

        public override StepName Clone()
            => MemberwiseClone() as StepName;
    }
}