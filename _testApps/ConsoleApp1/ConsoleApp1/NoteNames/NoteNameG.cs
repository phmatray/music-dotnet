namespace ConsoleApp1.NoteNames
{
    public class NoteNameG
        : NoteName
    {
        public override NoteNameAlias Alias { get; }
            = NoteNames.NoteNameAlias.G;

        public override int Value { get; }
            = 7;

        public override int Order { get; }
            = 5;

        public override string Name { get; }
            = "G";

        public override string NameLatin { get; }
            = "Sol";

        public override string ToString()
            => Name;

        public override NoteName Clone()
            => MemberwiseClone() as NoteName;
    }
}