namespace ConsoleApp1.NoteNames
{
    public class NoteNameC
        : NoteName
    {
        public override NoteNameAlias Alias { get; }
            = NoteNames.NoteNameAlias.C;

        public override int Value { get; }
            = 0;

        public override int Order { get; }
            = 1;

        public override string Name { get; }
            = "C";

        public override string NameLatin { get; }
            = "Do";

        public override string ToString()
            => Name;

        public override NoteName Clone()
            => MemberwiseClone() as NoteName;
    }
}