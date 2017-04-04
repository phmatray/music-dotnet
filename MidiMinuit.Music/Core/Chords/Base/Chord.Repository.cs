using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.Chords
{
    public partial class Chord
    {
        internal static List<Chord> CreateAll()
        {
            return Enum.GetValues(typeof(ChordAlias))
                .Cast<ChordAlias>()
                .Select(Create)
                .ToList();
        }

        internal static Chord Create(ChordAlias chordQuality)
        {
            /*
             * Implements FactoryPattern
             * https://www.codeproject.com/Articles/874246/Understanding-and-Implementing-Factory-Pattern-i
             */

            switch (chordQuality)
            {
                case ChordAlias.Major:
                    return new ChordMajor();
                case ChordAlias.Minor:
                    return new ChordMinor();
                case ChordAlias.MajorSixthMajor:
                    return new ChordMajorSixthMajor();
                case ChordAlias.MinorSixthMajor:
                    return new ChordMinorSixthMajor();
                case ChordAlias.SuspendedFourth:
                    return new ChordSuspendedFourth();
                case ChordAlias.Fifth:
                    return new ChordFifth();
                case ChordAlias.MajorAugmented:
                    return new ChordMajorAugmented();
                case ChordAlias.MinorDiminished:
                    return new ChordMinorDiminished();
                case ChordAlias.MajorSeventhMajor:
                    return new ChordMajorSeventhMajor();
                case ChordAlias.MajorSeventhMinor:
                    return new ChordMajorSeventhMinor();
                case ChordAlias.MinorSeventhMinor:
                    return new ChordMinorSeventhMinor();
                case ChordAlias.MinorFifthDiminishedSeventhMinor:
                    return new ChordMinorFifthDiminishedSeventhMinor();
                case ChordAlias.SuspendedFourthSeventhMinor:
                    return new ChordSuspendedFourthSeventhMinor();
                case ChordAlias.MajorAugmentedSeventhMinor:
                    return new ChordMajorAugmentedSeventhMinor();
                case ChordAlias.MinorDiminishedSeventhDiminished:
                    return new ChordMinorDiminishedSeventhDiminished();
                case ChordAlias.MinorSeventhMajor:
                    return new ChordMinorSeventhMajor();
                case ChordAlias.MajorNinthMajor:
                    return new ChordMajorNinthMajor();
                default:
                    throw new ArgumentOutOfRangeException(nameof(chordQuality), chordQuality, null);
            }
        }
    }
}