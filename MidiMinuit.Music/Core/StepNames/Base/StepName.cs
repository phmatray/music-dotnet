namespace MidiMinuit.Music.Core.NoteNames
{
    public abstract class StepName
    {
        public static implicit operator StepName(StepNameAlias alias)
        {
            var repo = new StepNameRepository();
            var stepName = repo.Get(alias);
            return stepName;
        }

        public static implicit operator StepNameAlias(StepName stepName)
        {
            return stepName.Alias;
        }

        public abstract StepNameAlias Alias { get; }

        public abstract int Semitones { get; }

        public abstract int MidiPitch { get; }

        public abstract int StepNumber { get; }

        public abstract string Name { get; }

        public abstract string NameLatin { get; }

        public abstract override string ToString();

        public abstract StepName Clone();
    }
}
