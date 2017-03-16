using MidiMinuit.Lib.Core.Intervals;

namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Chords;
    using Degrees;
    using Notes;
    using Tools;

    /*
     * Une gamme est l'application d'un mode. Par exemple la gamme de Sol majeur est l'application du mode majeur avec Sol comme note  fondamentale (Sol La Si Do Re Mi Fa#).
     *
     * Modes naturels / harmoniques / mélodiques
     *
     * gamme majeure aka mode Ionien
     * gamme mineure aka aeolien
     *
     * Parmi les 7 « modes naturels » il y a trois gammes majeures et quatre gammes mineures parmi lesquelles une gamme diminuée ( mode locrien ),
     *
     * Le mode «mixolydien b9/b13» (phrygien dominant), qui a des sonorité arabes, n’a rien à voir avec son altère ego naturel (le mode mixolydien), qui a des sonorités bluesy.
     *
     * intervalle d'une seconde augmentée (#9) qui est le même que celui de la tierce mineure (b3)
     *
     * Chaque degré a une fonction :
     * Le Ier degré a fonction de tonique
     * Le IIeme degré a fonction de sus-tonique
     * Le IIIeme degré a fonction de médiante
     * Le IVeme degré a fonction de sous-dominante
     * Le Veme degré a fonction de dominante
     * Le VIeme degré a fonction de sus-dominante
     * Le VIIeme degré a fonction de note sensible
    */

    public abstract class Scale
    {
        /// <summary>
        /// Gets the type of the scale.
        /// </summary>
        public abstract ScaleTypeEnum Quality { get; }

        /// <summary>
        /// Gets notes of the scale.
        /// </summary>
        public abstract List<IntervalQuality> Notes { get; }

        /// <summary>
        /// Gets name of the scale.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets details of the scale.
        /// </summary>
        public abstract string Details { get; }

        public abstract override string ToString();

        public abstract Scale Clone();

        ////public bool HasChord(ChordBase chord)
        ////{
        ////    var hasChord = chord.Notes
        ////        .Select(x => Notes.Any(y => y.Pitch == x.Pitch))
        ////        .All(x => x);

        ////    return hasChord;
        ////}

        ////public List<ChordBase> GetAllChord()
        ////{
        ////    var chords = Notes
        ////        // for each scale degree, we'll seach all the possibilities of chords.
        ////        .SelectMany(note => Constants.EnumListChordQualities.Select(cq => ChordExtensions.GetChord(cq, note)))
        ////        // check whether the chord created is in the scale.
        ////        .Where(chord => HasChord(chord))
        ////        // create the result
        ////        .ToList();

        ////    return chords;
        ////}







        ////// TODO: Move to ChordMajor
        ////public ChordBase GetChordMajor(DegreeBase degree)
        ////{
        ////    // Rebase the fondamental.
        ////    var fondamental = Notes[degree.DegreeIndex].Interval.Fondamental;

        ////    // Based on the new fondamental, gets the others notes.
        ////    var thirdMajor = fondamental.Interval.ThirdMajor;
        ////    var fifthPerfect = fondamental.Interval.FifthPerfect;

        ////    var isMajor = Notes.Any(x => x.Pitch == thirdMajor.Pitch) &&
        ////        Notes.Any(x => x.Pitch == fifthPerfect.Pitch);

        ////    return isMajor ? new ChordMajor(fondamental) : null;
        ////}

        ////// TODO: Move to ChordMinor
        ////public ChordBase GetChordMinor(DegreeBase degree)
        ////{
        ////    // Rebase the fondamental.
        ////    var fondamental = Notes[degree.DegreeIndex].Interval.Fondamental;

        ////    // Based on the new fondamental, gets the others notes.
        ////    var thirdMinor = fondamental.Interval.ThirdMinor;
        ////    var fifthPerfect = fondamental.Interval.FifthPerfect;

        ////    var isMinor = Notes.Any(x => x.Pitch == thirdMinor.Pitch) &&
        ////        Notes.Any(x => x.Pitch == fifthPerfect.Pitch);

        ////    return isMinor ? new ChordMinor(fondamental) : null;
        ////}

        ////// TODO: Move to ChordMinorDiminished
        ////public ChordBase GetChordMinorDiminished(DegreeBase degree)
        ////{
        ////    // Rebase the fondamental.
        ////    var fondamental = Notes[degree.DegreeIndex].Interval.Fondamental;

        ////    // Based on the new fondamental, gets the others notes.
        ////    var thirdMinor = fondamental.Interval.ThirdMinor;
        ////    var fifthDiminished = fondamental.Interval.FifthDiminished;

        ////    var isDiminished = Notes.Any(x => x.Pitch == thirdMinor.Pitch) &&
        ////        Notes.Any(x => x.Pitch == fifthDiminished.Pitch);

        ////    return isDiminished ? new ChordMinorDiminished(fondamental) : null;
        ////}
    }

    ////public class Toto
    ////{
    ////    public Toto()
    ////    {
    ////        List<Note> scaleMode = new Scale7AscendingMelodicMinor().Modes[Scale7AscendingMelodicMinorMode.Mode0_Larian];
    ////        List<Chord> chords = GenerateChords(scaleMode);
    ////        List<ChordPosition> chordPositions = GenerateChordPositions(chords[0], new Tunings.TuningStandard());
    ////    }
    ////}

    ////public abstract class Scale
    ////{
    ////    public string Name { get; protected set; }

    ////    public int Imperfections { get; protected set; }

    ////    public List<int> Intervals { get; protected set; }

    ////    public string ModeSuffix { get; protected set; }

    ////    public Note Key { get; protected set; }

    ////    // max interval
    ////    public int Leap
    ////        => Intervals.Max();
    ////}

    ////public abstract class Scale7 : Scale
    ////{
    ////    protected Scale7()
    ////    {
    ////        ModeSuffix = "-ian";
    ////    }
    ////}

    ////public class Scale7Major
    ////    : Scale7
    ////{
    ////    public Scale7Major(Note key = null)
    ////    {
    ////        Key = key ?? new Note(NoteNameEnum.C);
    ////        Name = "Major";
    ////        Imperfections = 3;
    ////        Intervals = new List<int> { 2, 2, 1, 2, 2, 2, 1 };

    ////        var notes = new List<Note>
    ////        {
    ////            Key,
    ////            Key + 2,
    ////            Key + 4,
    ////            Key + 6,
    ////            Key + 8,
    ////            Key + 9,
    ////            Key + 11
    ////        };

    ////        Modes = System.Enum
    ////            .GetValues(typeof(Scale7MajorMode))
    ////            .Cast<Scale7MajorMode>()
    ////            .ToDictionary(
    ////                x => x,
    ////                x => notes.ShiftLeft((int)x));
    ////    }

    ////    public Dictionary<Scale7MajorMode, List<Note>> Modes { get; private set; }
    ////}

    ////public enum Scale7MajorMode
    ////{
    ////    Mode4_Ionian = 0,
    ////    Mode5_Dorian = 1,
    ////    Mode6_Phrygian = 2,
    ////    Mode0_Lydian = 3,
    ////    Mode1_Mixolydian = 4,
    ////    Mode2_Aeolian = 5,
    ////    Mode3_Locrian = 6
    ////}

    ////public class Scale7AscendingMelodicMinor
    ////    : Scale7
    ////{
    ////    public Scale7AscendingMelodicMinor(Note key = null)
    ////    {
    ////        Key = key ?? new Note(NoteNameEnum.C);
    ////        Name = "Ascending Melodic Minor";
    ////        Imperfections = 3;
    ////        Intervals = new List<int> { 2, 2, 2, 2, 1, 2, 1 };

    ////        var notes = new List<Note>
    ////        {
    ////            Key,
    ////            Key + 2,
    ////            Key + 4,
    ////            Key + 6,
    ////            Key + 8,
    ////            Key + 9,
    ////            Key + 11
    ////        };

    ////        Modes = System.Enum
    ////            .GetValues(typeof(Scale7AscendingMelodicMinorMode))
    ////            .Cast<Scale7AscendingMelodicMinorMode>()
    ////            .ToDictionary(
    ////                x => x,
    ////                x => notes.ShiftLeft((int)x));
    ////    }

    ////    public Dictionary<Scale7AscendingMelodicMinorMode, List<Note>> Modes { get; private set; }
    ////}

    ////public enum Scale7AscendingMelodicMinorMode
    ////{
    ////    Mode0_Larian = 0,
    ////    Mode1_Lythian = 1,
    ////    Mode2_Stydian = 2,
    ////    Mode3_Lorian = 3,
    ////    Mode4_Ionadian = 4,
    ////    Mode5_Bocrian = 5,
    ////    Mode6_Mixolythian = 6
    ////}
}
