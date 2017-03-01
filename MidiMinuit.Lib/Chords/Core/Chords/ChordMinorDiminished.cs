using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMinorDiminished : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthDiminished FifthDiminished { get; }

        protected internal ChordMinorDiminished(Note fondamental, Note thirdMinor, Note fifthDiminished)
            : base(ChordQuality.MinorDiminished)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthDiminished = new NoteFifthDiminished(fifthDiminished);
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> { Fondamental, ThirdMinor, FifthDiminished };
        }

        public override string GetDescription()
        {
            return "Description not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th b: {FifthDiminished}";
        }

        public override string ToString()
        {
            return $"{Fondamental}dim";
        }
    }
}