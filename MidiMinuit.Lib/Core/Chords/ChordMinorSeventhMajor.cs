using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMinorSeventhMajor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public NoteSeventhMajor SeventhMajor { get; }

        public ChordMinorSeventhMajor(Note fondamental)
            : base(ChordQualityEnum.MinorSeventhMajor)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthPerfect = i.FifthPerfect;
            SeventhMajor = i.SeventhMajor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMinor, FifthPerfect, SeventhMajor };

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