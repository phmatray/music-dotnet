namespace MidiMinuit.Music.Core.NoteNames
{
    public class StepNameE
        : StepName
    {
        public override StepNameAlias Alias { get; }
            = StepNameAlias.E;

        public override int Semitones { get; }
            = 4;

        public override int MidiPitch { get; }
            = 64;

        public override int StepNumber { get; }
            = 3;

        public override string Name { get; }
            = "E";

        public override string NameLatin { get; }
            = "Mi";

        public override string ToString()
            => Name;

        public override StepName Clone()
            => MemberwiseClone() as StepName;
    }
}