namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using Notes;

    public class ChordFactory
    {
        public virtual Chord CreateChord(ChordQuality chordQuality, Note fondamental)
        {
            /*
             * Implements FactoryPattern
             * https://www.codeproject.com/Articles/874246/Understanding-and-Implementing-Factory-Pattern-i
             */

            switch (chordQuality)
            {
                case ChordQuality.Major:
                    return new ChordMajor(fondamental);
                case ChordQuality.Minor:
                    return new ChordMinor(fondamental);
                case ChordQuality.MajorSixthMajor:
                    return new ChordMajorSixthMajor(fondamental);
                case ChordQuality.MinorSixthMajor:
                    return new ChordMinorSixthMajor(fondamental);
                case ChordQuality.SuspendedFourth:
                    return new ChordSuspendedFourth(fondamental);
                case ChordQuality.Fifth:
                    return new ChordFifth(fondamental);
                case ChordQuality.MajorAugmented:
                    return new ChordMajorAugmented(fondamental);
                case ChordQuality.MinorDiminished:
                    return new ChordMinorDiminished(fondamental);
                case ChordQuality.MajorSeventhMajor:
                    return new ChordMajorSeventhMajor(fondamental);
                case ChordQuality.MajorSeventhMinor:
                    return new ChordMajorSeventhMinor(fondamental);
                case ChordQuality.MinorSeventhMinor:
                    return new ChordMinorSeventhMinor(fondamental);
                case ChordQuality.MinorFifthDiminishedSeventhMinor:
                    return new ChordMinorFifthDiminishedSeventhMinor(fondamental);
                case ChordQuality.SuspendedFourthSeventhMinor:
                    return new ChordSuspendedFourthSeventhMinor(fondamental);
                case ChordQuality.MajorAugmentedSeventhMinor:
                    return new ChordMajorAugmentedSeventhMinor(fondamental);
                case ChordQuality.MinorDiminishedSeventhDiminished:
                    return new ChordMinorDiminishedSeventhDiminished(fondamental);
                case ChordQuality.MinorSeventhMajor:
                    return new ChordMinorSeventhMajor(fondamental);
                case ChordQuality.MajorNinthMajor:
                    return new ChordMajorNinthMajor(fondamental);
                default:
                    throw new ArgumentOutOfRangeException(nameof(chordQuality), chordQuality, null);
            }
        }
    }
}