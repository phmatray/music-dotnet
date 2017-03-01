using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMinorFifthDiminishedSeventhMinor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        protected internal ChordMinorFifthDiminishedSeventhMinor(Note fondamental, Note thirdMinor, Note fifthDiminished, Note seventhMinor)
            : base(ChordQuality.MinorFifthDiminishedSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthDiminished = new NoteFifthDiminished(fifthDiminished);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> { Fondamental, ThirdMinor, FifthDiminished, SeventhMinor };
        }

        public override string GetDescription()
        {
            return "Description not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th b: {FifthDiminished}, 7th min: {SeventhMinor}";
        }

        public override string ToString()
        {
            return $"{Fondamental}min7b5";
        }
    }
}