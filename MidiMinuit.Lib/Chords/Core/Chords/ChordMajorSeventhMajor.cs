using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMajorSeventhMajor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMajor SeventhMajor { get; }

        protected internal ChordMajorSeventhMajor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note seventhMajor)
            : base(ChordQuality.MajorSeventhMajor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SeventhMajor = new NoteSeventhMajor(seventhMajor);
        }

        public override List<NoteRole> Notes
            => new List<NoteRole> { Fondamental, ThirdMajor, FifthPerfect, SeventhMajor };

        public override string Name
            => $"{Fondamental}M7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th: {FifthPerfect}, 7th maj: {SeventhMajor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}