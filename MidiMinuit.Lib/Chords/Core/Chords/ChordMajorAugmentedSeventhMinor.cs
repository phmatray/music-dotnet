using System.Collections.Generic;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes;
using MidiMinuit.Lib.Chords.Core.Notes.Base;

namespace MidiMinuit.Lib.Chords.Core.Chords
{
    public class ChordMajorAugmentedSeventhMinor : Chord
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthAugmented FifthAugmented { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        protected internal ChordMajorAugmentedSeventhMinor(Note fondamental, Note thirdMajor, Note fifthAugmented, Note seventhMinor)
            : base(ChordQuality.MajorAugmentedSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthAugmented = new NoteFifthAugmented(fifthAugmented);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteRole> Notes
            => new List<NoteRole> { Fondamental, ThirdMajor, FifthAugmented, SeventhMinor };

        public override string Name
            => $"{Fondamental}aug7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd maj: {ThirdMajor}, 5th #: {FifthAugmented}, 7th min: {SeventhMinor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}