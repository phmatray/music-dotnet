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

        public override List<NoteRole> Notes
            => new List<NoteRole> { Fondamental, FifthPerfect };

        public override string Name
            => $"{Fondamental}5";

        public override string Details
            => $"Fond: {Fondamental}, 5th: {FifthPerfect}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}