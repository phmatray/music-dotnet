using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMinor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        protected internal ChordMinor(Note fondamental, Note thirdMinor, Note fifthPerfect)
            : base(ChordQuality.Minor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
        }

        public override List<NoteRole> Notes
            => new List<NoteRole> { Fondamental, ThirdMinor, FifthPerfect };

        public override string Name
            => $"{Fondamental}min";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th: {FifthPerfect}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}