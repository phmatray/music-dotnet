using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordSuspendedFourthSeventhMinor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        protected internal ChordSuspendedFourthSeventhMinor(Note fondamental, Note fourthPerfect, Note fifthPerfect, Note seventhMinor)
            : base(ChordQualityEnum.MajorSuspendedFourthSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            FourthPerfect = new NoteFourthPerfect(fourthPerfect);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, FourthPerfect, FifthPerfect, SeventhMinor };

        public override string Name
            => $"{Fondamental}7sus4";

        public override string Details
            => $"Fond: {Fondamental}, 4th: {FourthPerfect}, 5th: {FifthPerfect}, 7th min: {SeventhMinor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}