using System;
using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Lib.Core.Chords;
using MidiMinuit.Lib.Core.Notes;
using MidiMinuit.Lib.Core.Scales;
using MidiMinuit.Lib.Core.Degrees;

namespace MidiMinuit.Lib.Tmp
{
    public static class Class1
    {
        public static void TestMethod_HarmonizeScale()
        {
            ScaleBase scale = new ScaleMajor(new Note(NoteNameEnum.C));
            var chord = scale.GetChord(new Degree2(), ChordQualityEnum.Minor);
        }

        public static void TestMethod_Generate3tonesChords()
        {
            List<NoteQuality> notes = IntervalHelper.GetScale(new Note(NoteNameEnum.C), ScaleTypeEnum.Major);
            var combinaisons = HelperBeta.GetCombinaisons(notes);

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

            //return new ChordMajor();
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