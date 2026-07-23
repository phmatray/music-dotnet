namespace OpenJam.Music.Core
{
    public partial class Degree
    {
        public static implicit operator DegreeAlias(Degree degree)
            => degree.Alias;

        public static implicit operator Degree(DegreeAlias alias)
            => Create(alias);
    }
}