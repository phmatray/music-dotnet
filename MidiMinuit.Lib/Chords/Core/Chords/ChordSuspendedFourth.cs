using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordSuspendedFourth : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        protected internal ChordSuspendedFourth(Note fondamental, Note fourthPerfect, Note fifthPerfect)
            : base(ChordQuality.MajorSuspendedFourth)
        {
            Fondamental = new NoteFondamental(fondamental);
            FourthPerfect = new NoteFourthPerfect(fourthPerfect);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> { Fondamental, FourthPerfect, FifthPerfect };
        }

        public override string GetDescription()
        {
            return "Descrition not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 4th: {FourthPerfect}, 5th: {FifthPerfect}";
        }

        public override string ToString()
        {
            return $"{Fondamental}sus4";
        }
    }
}