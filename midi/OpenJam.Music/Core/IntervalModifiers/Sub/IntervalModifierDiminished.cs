namespace OpenJam.Music.Core
{
    public class IntervalModifierDiminished
        : IntervalModifier
    {
        public override IntervalModifierAlias Alias { get; }
            = IntervalModifierAlias.Diminished;

        public override string Name { get; }
            = "Diminished";

        public override string Abbreviation { get; }
            = "d";

        public override IntervalModifier Inverse()
            => new IntervalModifierDiminished();

        public override string ToString()
            => Name;
    }
}