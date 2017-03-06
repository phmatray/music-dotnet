using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMajorAugmentedSeventhMinor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public NoteFifthAugmented FifthAugmented { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ChordMajorAugmentedSeventhMinor(Note fondamental)
            : base(ChordQualityEnum.MajorAugmentedSeventhMinor)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMajor = i.ThirdMajor;
            FifthAugmented = i.FifthAugmented;
            SeventhMinor = i.SeventhMinor;
        }

        protected internal ChordMajorAugmentedSeventhMinor(Note fondamental, Note thirdMajor, Note fifthAugmented, Note seventhMinor)
            : base(ChordQualityEnum.MajorAugmentedSeventhMinor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMajor = new NoteThirdMajor(thirdMajor);
            FifthAugmented = new NoteFifthAugmented(fifthAugmented);
            SeventhMinor = new NoteSeventhMinor(seventhMinor);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMajor, FifthAugmented, SeventhMinor };

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