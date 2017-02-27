using System;
using System.Collections.Generic;
using GuitarChords.Lib.Chords;
using GuitarChords.Lib.Chords.Enum;
using GuitarChords.Lib.Notes;
using GuitarChords.Lib.Scales.Enum;

namespace GuitarChords.Lib.Scales
{
    public class MajorScale : Scale
    {
        public MajorScale(Note key, ScaleMode mode = ScaleMode.Ionian)
            : base(ScaleType.Major, mode)
        {
            Notes = new List<Note>
            {
                key,
                key + 2,
                key + 4,
                key + 5,
                key + 7,
                key + 9,
                key + 11
            };
        }

        public MinorScale RelativeMinor => new MinorScale(Key - 3, Mode);

        //public List<Chord> Harmonize()
        //{
        //    if (Mode != ScaleMode.Ionian)
        //        throw new Exception("This mode is not supported.");

        //    var result = new List<Chord>
        //    {
        //        Notes[0].GetChord(ChordQuality.Major),
        //        Notes[1].GetChord(ChordQuality.Minor),
        //        Notes[2].GetChord(ChordQuality.Minor),
        //        Notes[3].GetChord(ChordQuality.Major),
        //        Notes[4].GetChord(ChordQuality.Major),
        //        Notes[5].GetChord(ChordQuality.Minor),
        //        Notes[6].GetChord(ChordQuality.MinorDiminished)
        //    };

        //    return result;
        //}
    }
}