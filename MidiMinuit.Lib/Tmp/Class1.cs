using System.Collections.Generic;
using System.Linq;
using MidiMinuit.Lib.Core.Chords;
using MidiMinuit.Lib.Core.Notes;
using MidiMinuit.Lib.Core.Scales;

namespace MidiMinuit.Lib.Tmp
{
    public static class Class1
    {
        public static void TestMethod_Generate3tonesChords()
        {
            List<NoteQuality> notes = IntervalHelper.GetScale(new Note(NoteNameEnum.C), ScaleTypeEnum.Major);
            var isMajorChord = IsMajorChord(notes);
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