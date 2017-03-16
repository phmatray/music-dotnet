namespace MidiMinuit.Lib.Core.Notes
{
    public enum NoteNameEnum
    {
        C = 0,
        D = 2,
        E = 4,
        F = 5,
        G = 7,
        A = 9,
        B = 11
    }

    public sealed class NoteName
    {
        private NoteName(int value, int order, string name, string nameLatin)
        {
            Value = value;
            Order = order;
            Name = name;
            NameLatin = nameLatin;
        }

        public static NoteName C { get; }
            = new NoteName(0, 0, "C", "Do");

        public static NoteName D { get; }
            = new NoteName(2, 1, "D", "Ré");

        public static NoteName E { get; }
            = new NoteName(4, 2, "E", "Mi");

        public static NoteName F { get; }
            = new NoteName(5, 3, "F", "Fa");

        public static NoteName G { get; }
            = new NoteName(7, 4, "G", "Sol");

        public static NoteName A { get; }
            = new NoteName(9, 5, "A", "La");

        public static NoteName B { get; }
            = new NoteName(11, 6, "B", "Si");

        public int Value { get; private set; }

        public int Order { get; private set; }

        public string Name { get; private set; }

        public string NameLatin { get; private set; }
    }
}