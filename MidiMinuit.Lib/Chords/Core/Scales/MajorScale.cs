using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Scales.Base;
using MidiMinuit.Lib.Chords.Core.Scales.Enum;

namespace MidiMinuit.Lib.Chords.Core.Scales
{
    //public class ChromaticScale : Scale
    //{
    //    public ChromaticScale(Note key, ScaleMode mode = ScaleMode.Ionian)
    //        : base(ScaleType.Chromatic, mode)
    //    {
    //        Notes = new List<Note>
    //        {
    //            key,
    //            key + 1,
    //            key + 2,
    //            key + 3,
    //            key + 4,
    //            key + 5,
    //            key + 6,
    //            key + 7,
    //            key + 8,
    //            key + 9,
    //            key + 10,
    //            key + 11,
    //        };
    //    }
    //}


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

        public MinorScale RelativeMinor => GetRelativeMinor(Key, Mode);

        public static MinorScale GetRelativeMinor(Note key, ScaleMode mode)
        {
            return new MinorScale(key - 3, mode);
        }

        // public List<Chord> Harmonize()
        // {
        //    if (Mode != ScaleMode.Ionian)
        //        throw new Exception("This mode is not supported.");

        // var result = new List<Chord>
        //    {
        //        Notes[0].GetChord(ChordQuality.Major),
        //        Notes[1].GetChord(ChordQuality.Minor),
        //        Notes[2].GetChord(ChordQuality.Minor),
        //        Notes[3].GetChord(ChordQuality.Major),
        //        Notes[4].GetChord(ChordQuality.Major),
        //        Notes[5].GetChord(ChordQuality.Minor),
        //        Notes[6].GetChord(ChordQuality.MinorDiminished)
        //    };

        // return result;
        // }
    }
}