using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMinorSeventhMinor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMinor SeventhMinor { get; }

        public ChordMinorSeventhMinor(Note fondamental)
            : base(ChordQualityEnum.MinorSeventhMinor)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthPerfect = i.FifthPerfect;
            SeventhMinor = i.SeventhMinor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMinor, FifthPerfect, SeventhMinor };

        public override string Name
            => $"{Fondamental}min7";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th: {FifthPerfect}, 7th min: {SeventhMinor}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}