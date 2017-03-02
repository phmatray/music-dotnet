using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMajor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        protected internal ChordMajor(Note fondamental, Note thirdMajor, Note fifthPerfect)
            : base(ChordQualityEnum.Major)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMajor, FifthPerfect };

        public override string Name
            => $"{Fondamental}maj";

        public override string Details
            => $"Fond: {Fondamental}, 3rd: {ThirdMajor}, 5th: {FifthPerfect}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}