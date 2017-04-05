namespace MidiMinuit.Music.Core
{
    public class IntervalStepOctave
        : IntervalStep
    {
        public override IntervalStepAlias Alias { get; }
            = IntervalStepAlias.Octave;

        public override int Steps { get; }
            = 8;

        public override string Name { get; }
            = "Octave";

        public override string Abbreviation { get; }
            = "octave";

        public override IntervalStep Inverse()
            => new IntervalStepOctave();

        public override string ToString()
            => Name;

        public override IntervalStep Clone()
            => MemberwiseClone() as IntervalStep;
    }
}