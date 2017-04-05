using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Music.Core;

namespace MidiMinuit.Music.Tmp
{
    public static class Class1
    {
        ////public static List<Chord> GetAllChordScaleMajorC()
        ////{
        ////    Scale scale = new ScaleMajor(new Note(NoteNameAlias.G));
        ////    var result = scale.GetAllChord();
        ////    return result;
        ////}

        ////public static List<Chord> GetAllChord(this Scale scale)
        ////{
        ////    var chords = scale.Notes
        ////        // for each scale degree, we'll seach all the possibilities of chords.
        ////        .SelectMany(note => Constants.EnumListChordQualities.Select(cq => ChordExtensions.GetChord(cq, note)))
        ////        // check whether the chord created is in the scale.
        ////        .Where(chord => scale.HasChord(chord))
        ////        // create the result
        ////        .ToList();

        ////    return chords;
        ////}

        ////public static void TestMethod_HarmonizeScale()
        ////{
        ////    Scale scale = new ScaleMajor(new Note(NoteNameAlias.C));
        ////    var chord = scale.GetChordMajor(new Degree1());
        ////}

        ////public static void TestMethod_Generate3tonesChords()
        ////{
        ////    Scale scale = new ScaleMajor(new Note(NoteNameAlias.C));
        ////    var combinaisons = HelperBeta.GetCombinaisons(scale.Notes);

        ////    var chords = new List<Chord>();
        ////    foreach (var c in combinaisons)
        ////    {
        ////        var chord = GetMajorChord(c);
        ////        chords.Add(chord);
        ////    }
        ////}

        public static Chord GetChord(List<IntervalAlias> notes)
        {
            if (notes == null)
            {
                throw new ArgumentNullException(nameof(notes));
            }

            if (notes.Count == 0)
            {
                throw new ArgumentException("Value cannot be an empty collection.", nameof(notes));
            }

            if (notes.Count != 3)
            {
                throw new ArgumentException("Value must contains 3 elements.", nameof(notes));
            }

            return null;

            // return new ChordMajor();
        }

        ////public static ChordMajor GetMajorChord(List<IntervalAlias> notes)
        ////{
        ////    if (IsMajorChord(notes))
        ////    {
        ////        var fondamental = notes.OfType<IntervalPerfectUnison>().SingleOrDefault();
        ////        return fondamental != null ? new ChordMajor(fondamental) : null;
        ////    }

        ////    return null;
        ////}

        public static bool IsMajorChord(List<IntervalAlias> notes)
        {
            return notes.OfType<IntervalPerfectUnison>().Any() &&
                   notes.OfType<IntervalMajorThird>().Any() &&
                   notes.OfType<IntervalPerfectFifth>().Any();
        }

        public static bool IsMinorChord(List<IntervalAlias> notes)
        {
            return notes.OfType<IntervalPerfectUnison>().Any() &&
                   notes.OfType<IntervalMinorThird>().Any() &&
                   notes.OfType<IntervalPerfectFifth>().Any();
        }
    }
}