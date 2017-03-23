namespace MidiMinuit.Lib.Core.NoteNames
{
    public class NoteNameB
        : NoteName
    {
        public override NoteNameAlias Alias { get; }
            = NoteNameAlias.B;

        public override int Value { get; }
            = 11;

        public override int Order { get; }
            = 7;

        public override string Name { get; }
            = "B";

        public override string NameLatin { get; }
            = "Si";

        public override string ToString()
            => Name;

        public override NoteName Clone()
            => MemberwiseClone() as NoteName;
    }
}