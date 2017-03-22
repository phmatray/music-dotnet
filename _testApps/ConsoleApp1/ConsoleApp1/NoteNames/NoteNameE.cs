namespace ConsoleApp1.NoteNames
{
    public class NoteNameE
        : NoteName
    {
        public override Name NameEnum { get; }
            = NoteNames.Name.E;

        public override int Value { get; }
            = 4;

        public override int Order { get; }
            = 3;

        public override string Name { get; }
            = "E";

        public override string NameLatin { get; }
            = "Mi";

        public override string ToString()
            => Name;

        public override NoteName Clone()
            => MemberwiseClone() as NoteName;
    }
}