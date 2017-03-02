using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public abstract class ChordBase
    {
        public static ChordBase GetChord(Note fondamental, ChordQualityEnum quality = ChordQualityEnum.Major)
        {
            switch (quality)
            {
                case ChordQualityEnum.Major:
                    return new ChordMajor(fondamental);
                case ChordQualityEnum.Minor:
                    return new ChordMinor(fondamental);
                case ChordQualityEnum.MajorSixthMajor:
                    return new ChordMajorSixthMajor(fondamental);
                case ChordQualityEnum.MinorSixthMajor:
                    return new ChordMinorSixthMajor(fondamental);
                case ChordQualityEnum.MajorSuspendedFourth:
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
                case ChordQualityEnum.MajorSuspendedFourthSeventhMinor:
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
                    throw new ArgumentOutOfRangeException(nameof(quality));
            }
        }

        protected ChordBase(ChordQualityEnum quality)
        {
            Quality = quality;
        }

        public ChordQualityEnum Quality { get; }

        public abstract List<NoteQuality> Notes { get; }

        public abstract string Name { get; }

        public abstract string Details { get; }

        public abstract string Description { get; }

        public abstract override string ToString();

        ////private readonly List<Note> _notes;

        ////public Chord(params Note[] notes)
        ////{
        ////    if (notes == null)
        ////        throw new ArgumentNullException("notes");
        ////    if (notes.Length == 0)
        ////        throw new ArgumentException("notes cannot be empty", "notes");

        ////    _notes = notes.ToList();
        ////}

        ////public Chord(string symbol)
        ////{
        ////    if (!ChordValidationPatternStrict.IsMatch(symbol))
        ////        throw new ArgumentException("Couldn't parse", "symbol");

        ////    var root = symbol.Length == 1
        ////        ? symbol
        ////        : (symbol[1] == 'b' || symbol[1] == '#'
        ////            ? symbol.Substring(0, 2)
        ////            : symbol[0].ToString());

        ////    var rootNote = new Note(root);

        ////    // var chord = Chord.Search("Am");
        ////    // var chord = Chord.Search("Cmaj7");
        ////    throw new NotImplementedException();
        ////}

        ////public Regex ChordValidationPattern
        ////{
        ////    get
        ////    {
        ////        return new Regex(@"^([CF][♯#]?|[ABDEG][♭b]?) ?" +
        ////                         @"(((Major|maj?|M)(6|7([♯#♭b]5)?|11|(9|13)([♯#]11)?)?|Δ7?)|" +
        ////                         @"((Minor|min?|[m−-])(((maj)?[79]|Δ7?)|11|13|(6?(add9)?)|7[♯#♭b]5)?|ø7?)|" +
        ////                         @"-?5|" +
        ////                         @"6?(add(9|11))?|" +
        ////                         @"7(sus4|\+[59]|[♯#]11|[♯#♭b][59]|[♭b]13|\([♯#♭b]5,[♯#♭b]9\))?|" +
        ////                         @"9(sus4|[♯#]11|[♯#♭b]5)?|" +
        ////                         @"11([♭b]9)?|" +
        ////                         @"13(sus4|[♯#]11|[♭b]9)?|" +
        ////                         @"(aug|\+)7?|" +
        ////                         @"(dim|[°o])7?|" +
        ////                         @"(sus)?[24]|" +
        ////                         @"sus2sus4)?$");
        ////    }
        ////}

        ////public Regex ChordValidationPatternStrict
        ////{
        ////    get
        ////    {
        ////        return new Regex(@"^([CF]#?|[ABDEG]b?)" +
        ////                         @"(Major|maj(7|9|11|13)|maj(9|13)#11|6|6?add9|maj7[b#]5|" +
        ////                         @"Minor|m(7|9|11|13|6)|m6?add9|mmaj[79]|m7[b#]5|7|9|11|13|" +
        ////                         @"7sus4|7[b#][59]|7\(b5,[b#]9\)|7\(#5,[b#]9\)|9[b#]5|13#11|" +
        ////                         @"1[13]b9|aug|dim7?|5|sus[24]|sus2sus4|-5)?$");
        ////    }
        ////}

        /////// <summary>
        ///////     The root note (e.g. C).
        /////// </summary>
        ////public Note RootNote { get; private set; }

        /////// <summary>
        ///////     The chord quality (e.g. major, maj, or M).
        /////// </summary>
        //////public string Quality { get; private set; }

        /////// <summary>
        ///////     The number of an interval (e.g. seventh, or 7),
        ///////     or less often its full name or symbol (e.g. major seventh, maj7, or M7).
        /////// </summary>
        ////public string NumberOfAnInterval { get; set; }

        /////// <summary>
        ///////     The altered fifth (e.g. sharp five, or ♯5).
        /////// </summary>
        ////public string AlteredFifth { get; set; }

        /////// <summary>
        ///////     An additional interval number (e.g. add 13 or add13), in added tone chords.
        /////// </summary>
        ////public string AdditionalIntervalNumber { get; set; }

        ////private List<int> GetIntervals(/*string third, string fifth, string? seventh*/)
        ////{
        ////    //third = major;
        ////    //fifth = perfect;
        ////    //... so
        ////    //return {0, 4, 7}

        ////    throw new NotImplementedException();
        ////}

        ////private List<int> GetIntervals(IntervalThird third, IntervalFifth fifth)
        ////{
        ////    var result = new List<int>() {0};

        ////    result.Add((int)third);
        ////    result.Add((int)fifth);

        ////    return result;
        ////}

        //////private List<Note> GetNotes(Note root, Triads triads)
        //////{
        //////}
    }
}