using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMajorSeventhMinor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        protected internal ChordMajorSeventhMinor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note seventhMinor)
            : base(ChordQualityEnum.MajorSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMajor, FifthPerfect, SeventhMinor };

        public override string Name
            => $"{Fondamental}7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th: {FifthPerfect}, 7th min: {SeventhMinor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}