using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMajorSeventhMajor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMajor SeventhMajor { get; }

        protected internal ChordMajorSeventhMajor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note seventhMajor)
            : base(ChordQualityEnum.MajorSeventhMajor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SeventhMajor = new NoteSeventhMajor(seventhMajor);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMajor, FifthPerfect, SeventhMajor };

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