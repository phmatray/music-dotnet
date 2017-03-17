namespace MidiMinuit.Lib.Core.Chords
{
    using System.Collections.Generic;
    using Intervals;

    public abstract class Chord
    {
        /// <summary>
        ///     Gets the quality of the chord.
        /// </summary>
        public abstract ChordQuality Quality { get; }

        /// <summary>
        ///     Gets notes of the chord.
        /// </summary>
        public abstract List<IntervalQuality> Notes { get; }

        /// <summary>
        ///     Gets name of the chord.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        ///     Gets details of the chord.
        /// </summary>
        public abstract string Details { get; }

        /// <summary>
        ///     Gets description of the chord.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        ///     Gets nombre de sons constituant l'accord
        /// </summary>
        public int ToneCount
            => Notes.Count;

        public abstract override string ToString();

        public abstract Chord Clone();

        ////    _notes = notes.ToList();
        ////        throw new ArgumentException("notes cannot be empty", "notes");
        ////    if (notes.Length == 0)
        ////        throw new ArgumentNullException("notes");
        ////    if (notes == null)
        ////{

        ////public Chord(params Note[] notes)

        ////private readonly List<Note> _notes;
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