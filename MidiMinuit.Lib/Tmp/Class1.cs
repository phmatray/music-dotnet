namespace MidiMinuit.Lib.Tmp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MidiMinuit.Lib.Core.Chords;
    using MidiMinuit.Lib.Core.Degrees;
    using MidiMinuit.Lib.Core.Notes;
    using MidiMinuit.Lib.Core.Scales;

    public static class Class1
    {
        public static List<ChordBase> GetAllChordScaleMajorC()
        {
            ScaleBase scale = new ScaleMajor(new Note(NoteNameEnum.G));
            var result = scale.GetAllChord();
            return result;
        }

        ////public static List<ChordBase> GetAllChord(this ScaleBase scale)
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

        public static void TestMethod_HarmonizeScale()
        {
            ScaleBase scale = new ScaleMajor(new Note(NoteNameEnum.C));
            var chord = scale.GetChordMajor(new Degree1());
        }

        public static void TestMethod_Generate3tonesChords()
        {
            ScaleBase scale = new ScaleMajor(new Note(NoteNameEnum.C));
            var combinaisons = HelperBeta.GetCombinaisons(scale.Notes);

            var chords = new List<ChordBase>();
            foreach (var c in combinaisons)
            {
                var chord = GetMajorChord(c);
                chords.Add(chord);
            }
        }

        public static ChordBase GetChord(List<NoteQuality> notes)
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

        public static ChordMajor GetMajorChord(List<NoteQuality> notes)
        {
            if (IsMajorChord(notes))
            {
                var fondamental = notes.OfType<NoteFondamental>().SingleOrDefault();
                return fondamental != null ? new ChordMajor(fondamental) : null;
            }

            return null;
        }

        public static bool IsMajorChord(List<NoteQuality> notes)
        {
            return notes.OfType<NoteFondamental>().Any() &&
                   notes.OfType<NoteThirdMajor>().Any() &&
                   notes.OfType<NoteFifthPerfect>().Any();
        }

        public static bool IsMinorChord(List<NoteQuality> notes)
        {
            return notes.OfType<NoteFondamental>().Any() &&
                   notes.OfType<NoteThirdMinor>().Any() &&
                   notes.OfType<NoteFifthPerfect>().Any();
        }
    }
}