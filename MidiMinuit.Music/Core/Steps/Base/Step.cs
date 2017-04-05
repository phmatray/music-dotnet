namespace MidiMinuit.Music.Core
{
    public partial class Step
    {
        public StepName Name { get; set; }

        public StepAccidental Accidental { get; set; }

        public Step(string name, int accidentalValue)
        {
            Name = name;
            Accidental = accidentalValue;
        }

        public Step(StepNameAlias name, StepAccidentalAlias accidental = StepAccidentalAlias.Natural)
        {
            Name = name;
            Accidental = accidental;
        }

        public Step(string s)
            : this((Step)s)
        {
        }

        public Step(Step step)
            : this(step.Name, step.Accidental)
        {
        }

        protected Step()
        {
        }

        public static Step FromPitch(Pitch pitch)
        {
            return new Step { Name = pitch.Name, Accidental = pitch.Accidental };
        }

        public Pitch ToPitch(int octaveNumber = 4)
        {
            return Pitch.FromStep(this, octaveNumber);
        }

        public override string ToString()
        {
            return $"{Name}{Accidental.SignAscii}";
        }
    }
}