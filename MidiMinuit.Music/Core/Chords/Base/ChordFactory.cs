using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.Music.Core.Chords
{
    public class ChordFactory
    {
        public List<Chord> CreateAllChords(Pitch fondamental)
        {
            return Enum.GetValues(typeof(ChordAlias))
                .Cast<ChordAlias>()
                .Select(x => CreateChord(x, fondamental))
                .ToList();
        }

        public Chord CreateChord(ChordAlias chordQuality, Pitch fondamental)
        {
            /*
             * Implements FactoryPattern
             * https://www.codeproject.com/Articles/874246/Understanding-and-Implementing-Factory-Pattern-i
             */

            switch (chordQuality)
            {
                case ChordAlias.Major:
                    return new ChordMajor(fondamental);
                case ChordAlias.Minor:
                    return new ChordMinor(fondamental);
                case ChordAlias.MajorSixthMajor:
                    return new ChordMajorSixthMajor(fondamental);
                case ChordAlias.MinorSixthMajor:
                    return new ChordMinorSixthMajor(fondamental);
                case ChordAlias.SuspendedFourth:
                    return new ChordSuspendedFourth(fondamental);
                case ChordAlias.Fifth:
                    return new ChordFifth(fondamental);
                case ChordAlias.MajorAugmented:
                    return new ChordMajorAugmented(fondamental);
                case ChordAlias.MinorDiminished:
                    return new ChordMinorDiminished(fondamental);
                case ChordAlias.MajorSeventhMajor:
                    return new ChordMajorSeventhMajor(fondamental);
                case ChordAlias.MajorSeventhMinor:
                    return new ChordMajorSeventhMinor(fondamental);
                case ChordAlias.MinorSeventhMinor:
                    return new ChordMinorSeventhMinor(fondamental);
                case ChordAlias.MinorFifthDiminishedSeventhMinor:
                    return new ChordMinorFifthDiminishedSeventhMinor(fondamental);
                case ChordAlias.SuspendedFourthSeventhMinor:
                    return new ChordSuspendedFourthSeventhMinor(fondamental);
                case ChordAlias.MajorAugmentedSeventhMinor:
                    return new ChordMajorAugmentedSeventhMinor(fondamental);
                case ChordAlias.MinorDiminishedSeventhDiminished:
                    return new ChordMinorDiminishedSeventhDiminished(fondamental);
                case ChordAlias.MinorSeventhMajor:
                    return new ChordMinorSeventhMajor(fondamental);
                case ChordAlias.MajorNinthMajor:
                    return new ChordMajorNinthMajor(fondamental);
                default:
                    throw new ArgumentOutOfRangeException(nameof(chordQuality), chordQuality, null);
            }
        }
    }
}