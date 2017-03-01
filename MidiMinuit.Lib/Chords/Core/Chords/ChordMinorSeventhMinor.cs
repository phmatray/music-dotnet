using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMinorSeventhMinor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        protected internal ChordMinorSeventhMinor(Note fondamental, Note thirdMinor, Note fifthPerfect, Note seventhMinor)
            : base(ChordQuality.MinorSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> { Fondamental, ThirdMinor, FifthPerfect, SeventhMinor };
        }

        public override string GetDescription()
        {
            return "Description not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th: {FifthPerfect}, 7th min: {SeventhMinor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}min7";
        }
    }
}