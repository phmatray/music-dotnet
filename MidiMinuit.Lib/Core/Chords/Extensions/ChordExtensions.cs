namespace MidiMinuit.Lib.Core.Chords
{
    using System;
    using MidiMinuit.Lib.Core.Notes;

    public static class ChordExtensions
    {
        public static ChordBase GetChord(this ChordQualityEnum chordQuality, Note fondamental)
        {
            switch (chordQuality)
            {
                case ChordQualityEnum.Major:
                    return new ChordMajor(fondamental);
                case ChordQualityEnum.Minor:
                    return new ChordMinor(fondamental);
                case ChordQualityEnum.MajorSixthMajor:
                    return new ChordMajorSixthMajor(fondamental);
                case ChordQualityEnum.MinorSixthMajor:
                    return new ChordMinorSixthMajor(fondamental);
                case ChordQualityEnum.SuspendedFourth:
                    return new ChordSuspendedFourth(fondamental);
                case ChordQualityEnum.Fifth:
                    return new ChordFifth(fondamental);
                case ChordQualityEnum.MajorAugmented:
                    return new ChordMajorAugmented(fondamental);
                case ChordQualityEnum.MinorDiminished:
                    return new ChordMinorDiminished(fondamental);
                case ChordQualityEnum.MajorSeventhMajor:
                    return new ChordMajorSeventhMajor(fondamental);
                case ChordQualityEnum.MajorSeventhMinor:
                    return new ChordMajorSeventhMinor(fondamental);
                case ChordQualityEnum.MinorSeventhMinor:
                    return new ChordMinorSeventhMinor(fondamental);
                case ChordQualityEnum.MinorFifthDiminishedSeventhMinor:
                    return new ChordMinorFifthDiminishedSeventhMinor(fondamental);
                case ChordQualityEnum.SuspendedFourthSeventhMinor:
                    return new ChordSuspendedFourthSeventhMinor(fondamental);
                case ChordQualityEnum.MajorAugmentedSeventhMinor:
                    return new ChordMajorAugmentedSeventhMinor(fondamental);
                case ChordQualityEnum.MinorDiminishedSeventhDiminished:
                    return new ChordMinorDiminishedSeventhDiminished(fondamental);
                case ChordQualityEnum.MinorSeventhMajor:
                    return new ChordMinorSeventhMajor(fondamental);
                case ChordQualityEnum.MajorNinthMajor:
                    return new ChordMajorNinthMajor(fondamental);
                default:
                    throw new ArgumentOutOfRangeException(nameof(chordQuality), chordQuality, null);
            }
        }
    }
}