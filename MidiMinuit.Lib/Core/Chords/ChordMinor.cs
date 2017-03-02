using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordMinor : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteThirdMinor ThirdMinor { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public ChordMinor(Note fondamental)
            : base(ChordQualityEnum.Minor)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            ThirdMinor = i.ThirdMinor;
            FifthPerfect = i.FifthPerfect;
        }

        protected internal ChordMinor(Note fondamental, Note thirdMinor, Note fifthPerfect)
            : base(ChordQualityEnum.Minor)
        {
            Fondamental = new NoteFondamental(fondamental);
            ThirdMinor = new NoteThirdMinor(thirdMinor);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, ThirdMinor, FifthPerfect };

        public override string Name
            => $"{Fondamental}min";

        public override string Details
            => $"Fond: {Fondamental}, 3rd min: {ThirdMinor}, 5th: {FifthPerfect}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}