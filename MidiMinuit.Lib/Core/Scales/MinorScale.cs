//using System.Collections.Generic;
//using MidiMinuit.Lib.Chords.Core.Notes.Base;
//using MidiMinuit.Lib.Chords.Core.Scales.Base;
//using MidiMinuit.Lib.Chords.Core.Scales.Enum;
//using MidiMinuit.Lib.Chords.Tools.Extensions;

//namespace MidiMinuit.Lib.Chords.Core.Scales
//{
//    public class MinorScale : Scale
//    {
//        public MinorScale(Note key, ScaleMode mode = ScaleMode.Ionian)
//            : base(ScaleType.Minor, mode)
//        {
//            var notes = new List<Note>
//            {
//                key,
//                key + 2,
//                key + 3,
//                key + 5,
//                key + 7,
//                key + 8,
//                key + 10
//            };

//            // take the value of ScaleMode enum and substract 1.
//            var shiftIteration = (int)mode - 1;

//            // shift the note for to get the right mode.
//            Notes = notes.ShiftLeft(shiftIteration);
//        }

//        public MajorScale RelativeMajor => GetRelativeMajor(Key, Mode);

//        public static MajorScale GetRelativeMajor(Note key, ScaleMode mode)
//        {
//            return new MajorScale(key + 3, mode);
//        }
//    }
//}