using System;
using System.Collections.Generic;
using GuitarChords.Lib.Notes;
using GuitarChords.Lib.Scales;
using GuitarChords.Lib.Scales.Enum;

namespace GuitarChords.Lib.Extensions
{
    public static class NoteExtension
    {
        #region Interval

        public static Interval GetInterval(this Note note)
        {
            return Note.GetInterval(note);
        }

        #endregion

        #region Scale

        public static Scale GetScale(this Note key, ScaleType type = ScaleType.Major)
        {
            switch (type)
            {
                case ScaleType.Major:
                    return new MajorScale(key);
                case ScaleType.Minor:
                    return new MinorScale(key);
                case ScaleType.MinorHarmonic:
                case ScaleType.MinorMelodicAscendant:
                case ScaleType.MinorMelodicDescendant:
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }

        ////private static MajorScale GetScaleMajor(Note key)
        ////{
        ////    return new MajorScale(key);


        ////    var scaleMajor = new List<Note>
        ////    {
        ////        key,
        ////        key + 2,
        ////        key + 4,
        ////        key + 5,
        ////        key + 7,
        ////        key + 9,
        ////        key + 11
        ////    };

        ////    if (key.Accidental == NoteAccidental.Sharp)
        ////    {
        ////        scaleMajor = scaleMajor
        ////            .Select(n => n.ToFlat())
        ////            .ToList();
        ////    }

        ////    return scaleMajor;
        ////}

        ////private static MinorScale GetScaleMinor(Note key)
        ////{
        ////    return new List<Note>
        ////    {
        ////        key,
        ////        key + 2,
        ////        key + 3,
        ////        key + 5,
        ////        key + 7,
        ////        key + 8,
        ////        key + 10
        ////    };
        ////}

        private static List<Note> GetScaleMinorHarmonic(Note key)
        {
            return new List<Note>
            {
                key,
                key + 2,
                key + 3,
                key + 5,
                key + 7,
                key + 8,
                key + 11
            };
        }

        private static List<Note> GetScaleMinorMelodicAscendant(Note key)
        {
            return new List<Note>
            {
                key,
                key + 2,
                key + 3,
                key + 5,
                key + 7,
                key + 9,
                key + 11
            };
        }

        private static List<Note> GetScaleMinorMelodicDescendant(Note key)
        {
            return new List<Note>
            {
                key,
                key - 2,
                key - 4,
                key - 5,
                key - 7,
                key - 9,
                key - 10
            };
        }

        #endregion
    }
}