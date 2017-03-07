using System;
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

        public ChordSuspendedFourthSeventhMinor(Note fondamental)
            : base(ChordQualityEnum.SuspendedFourthSeventhMinor)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
            SeventhMinor = i.SeventhMinor;
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