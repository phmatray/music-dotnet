namespace ConsoleApp1.NoteNames
{
    public class NoteNameF
        : NoteName
    {
        public override Name NameEnum { get; }
            = NoteNames.Name.F;

        public override int Value { get; }
            = 5;

        public override int Order { get; }
            = 4;

        public override string Name { get; }
            = "F";

        public override string NameLatin { get; }
            = "Fa";

        public override string ToString()
            => Name;

        public override NoteName Clone()
            => MemberwiseClone() as NoteName;
    }
}