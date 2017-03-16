namespace MidiMinuit.Lib.Core.Chords
{
    public sealed class ChordQuality
    {
        private ChordQuality(int order, string name)
        {
            Order = order;
            Name = name;
        }

        public static ChordQuality Major { get; }
            = new ChordQuality(0, nameof(Major));

        public static ChordQuality Minor { get; }
            = new ChordQuality(1, nameof(Minor));

        public static ChordQuality MajorSixthMajor { get; }
            = new ChordQuality(2, nameof(MajorSixthMajor));

        public static ChordQuality MinorSixthMajor { get; }
            = new ChordQuality(3, nameof(MinorSixthMajor));

        public static ChordQuality SuspendedFourth { get; }
            = new ChordQuality(4, nameof(SuspendedFourth));

        public static ChordQuality Fifth { get; }
            = new ChordQuality(5, nameof(Fifth));

        public static ChordQuality MajorAugmented { get; }
            = new ChordQuality(6, nameof(MajorAugmented));

        public static ChordQuality MinorDiminished { get; }
            = new ChordQuality(7, nameof(MinorDiminished));

        public static ChordQuality MajorSeventhMajor { get; }
            = new ChordQuality(8, nameof(MajorSeventhMajor));

        public static ChordQuality MajorSeventhMinor { get; }
            = new ChordQuality(9, nameof(MajorSeventhMinor));

        public static ChordQuality MinorSeventhMinor { get; }
            = new ChordQuality(10, nameof(MinorSeventhMinor));

        public static ChordQuality MinorFifthDiminishedSeventhMinor { get; }
            = new ChordQuality(11, nameof(MinorFifthDiminishedSeventhMinor));

        public static ChordQuality SuspendedFourthSeventhMinor { get; }
            = new ChordQuality(12, nameof(SuspendedFourthSeventhMinor));

        public static ChordQuality MajorAugmentedSeventhMinor { get; }
            = new ChordQuality(13, nameof(MajorAugmentedSeventhMinor));

        public static ChordQuality MinorDiminishedSeventhDiminished { get; }
            = new ChordQuality(14, nameof(MinorDiminishedSeventhDiminished));

        public static ChordQuality MinorSeventhMajor { get; }
            = new ChordQuality(15, nameof(MinorSeventhMajor));

        public static ChordQuality MajorNinthMajor { get; }
            = new ChordQuality(16, nameof(MajorNinthMajor));

        public int Order { get; }

        public string Name { get; }

        public override string ToString()
            => Name;
    }
}