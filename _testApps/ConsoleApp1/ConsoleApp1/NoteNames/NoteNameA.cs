namespace ConsoleApp1.NoteNames
{
    public class NoteNameA
        : NoteName
    {
        public override Name NameEnum { get; }
            = NoteNames.Name.A;

        public override int Value { get; }
            = 9;

        public override int Order { get; }
            = 6;

        public override string Name { get; }
            = "A";

        public override string NameLatin { get; }
            = "La";

        public override string ToString()
            => Name;

        public override NoteName Clone()
            => MemberwiseClone() as NoteName;
    }
}