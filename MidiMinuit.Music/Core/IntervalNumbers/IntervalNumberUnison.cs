namespace MidiMinuit.Music.Core.IntervalNumbers
{
    public class IntervalNumberUnison
        : IntervalNumber
    {
        public override IntervalNumberAlias Alias { get; }
            = IntervalNumberAlias.Unison;

        public override int Order { get; }
            = 1;

        public override string Name { get; }
            = "Unison";

        public override string Abbreviation { get; }
            = "unison";
        public override IntervalNumber Inverse()
            => new IntervalNumberUnison();

        public override string ToString()
            => Name;

        public override IntervalNumber Clone()
            => MemberwiseClone() as IntervalNumber;
    }
}