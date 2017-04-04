namespace MidiMinuit.Music.Core.Chords
{
    public partial class Chord
    {
        public static Chord Major
            => Create(ChordAlias.Major);

        public static Chord Minor
            => Create(ChordAlias.Minor);

        public static Chord MajorSixthMajor
            => Create(ChordAlias.MajorSixthMajor);

        public static Chord MinorSixthMajor
            => Create(ChordAlias.MinorSixthMajor);

        public static Chord SuspendedFourth
            => Create(ChordAlias.SuspendedFourth);

        public static Chord Fifth
            => Create(ChordAlias.Fifth);

        public static Chord MajorAugmented
            => Create(ChordAlias.MajorAugmented);

        public static Chord MinorDiminished
            => Create(ChordAlias.MinorDiminished);

        public static Chord MajorSeventhMajor
            => Create(ChordAlias.MajorSeventhMajor);

        public static Chord MajorSeventhMinor
            => Create(ChordAlias.MajorSeventhMinor);

        public static Chord MinorSeventhMinor
            => Create(ChordAlias.MinorSeventhMinor);

        public static Chord MinorFifthDiminishedSeventhMinor
            => Create(ChordAlias.MinorFifthDiminishedSeventhMinor);

        public static Chord SuspendedFourthSeventhMinor
            => Create(ChordAlias.SuspendedFourthSeventhMinor);

        public static Chord MajorAugmentedSeventhMinor
            => Create(ChordAlias.MajorAugmentedSeventhMinor);

        public static Chord MinorDiminishedSeventhDiminished
            => Create(ChordAlias.MinorDiminishedSeventhDiminished);

        public static Chord MinorSeventhMajor
            => Create(ChordAlias.MinorSeventhMajor);

        public static Chord MajorNinthMajor
            => Create(ChordAlias.MajorNinthMajor);
    }
}