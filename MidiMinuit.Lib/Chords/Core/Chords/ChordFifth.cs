using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordFifth : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        protected internal ChordFifth(Note fondamental, Note fifthPerfect)
            : base(ChordQuality.Fifth)
        {
            Fondamental = fondamental as NoteFondamental;
            FifthPerfect = fifthPerfect as NoteFifthPerfect;
        }

        public override List<NoteRole> GetNotes()
        {
            return new List<NoteRole> { Fondamental, FifthPerfect };
        }

        public override string GetDescription()
        {
            return "Description not added yet.";
        }

        public override string Format()
        {
            return $"Fond: {Fondamental}, 5th: {FifthPerfect}";
        }

        public override string ToString()
        {
            return $"{Fondamental}5";
        }
    }
}