using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMinorSeventhMajor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMajor SeventhMajor { get; }

        protected internal ChordMinorSeventhMajor(Note fondamental, Note thirdMinor, Note fifthPerfect, Note seventhMajor)
            : base(ChordQuality.MinorSeventhMajor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SeventhMajor = new NoteSeventhMajor(seventhMajor);
        }

        public override List<NoteRole> Notes
            => new List<NoteRole> { Fondamental, ThirdMinor, FifthPerfect, SeventhMajor };

        public override string Name
            => $"{Fondamental}min maj7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th: {FifthPerfect}, 7th maj: {SeventhMajor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}