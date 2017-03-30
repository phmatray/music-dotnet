namespace MidiMinuit.Music.Core.NoteNames
{
    public class NoteNameD
        : NoteName
    {
        public override NoteNameAlias Alias { get; }
            = NoteNameAlias.D;

        public override int Value { get; }
            = 2;

        public override int Order { get; }
            = 2;

        public override string Name { get; }
            = "D";

        public override string NameLatin { get; }
            = "Ré";

        public override string ToString()
            => Name;

        public override NoteName Clone()
            => MemberwiseClone() as NoteName;
    }
}