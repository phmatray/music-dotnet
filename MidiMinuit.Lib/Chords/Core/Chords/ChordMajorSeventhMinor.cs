using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMajorSeventhMinor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        protected internal ChordMajorSeventhMinor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note seventhMinor)
            : base(ChordQuality.MajorSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> { Fondamental, ThirdMajor, FifthPerfect, SeventhMinor };
        }

        public override string GetDescription()
        {
            return "Description not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th: {FifthPerfect}, 7th min: {SeventhMinor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}7";
        }
    }
}