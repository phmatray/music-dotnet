using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMajorSixthMajor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSixthMajor SixthMajor { get; }

        protected internal ChordMajorSixthMajor(Note fondamental, Note thirdMajor, Note fifthPerfect, Note sixthMajor)
            : base(ChordQuality.MajorSixthMajor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
            SixthMajor = new NoteSixthMajor(sixthMajor);
        }

        public override List<NoteRole> Notes
            => new List<NoteRole> { Fondamental, ThirdMajor, FifthPerfect, SixthMajor };

        public override string Name
            => $"{Fondamental}6";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th: {FifthPerfect}, 6th maj: {SixthMajor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}