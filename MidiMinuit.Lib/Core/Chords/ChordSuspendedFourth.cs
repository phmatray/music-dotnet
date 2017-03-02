using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Chords
{
    public class ChordSuspendedFourth : ChordBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteFourthPerfect FourthPerfect { get; }

        public NoteFifthPerfect FifthPerfect { get; }

        public ChordSuspendedFourth(Note fondamental)
            : base(ChordQualityEnum.MajorSuspendedFourth)
        {
            if (fondamental == null)
            {
                throw new ArgumentNullException(nameof(fondamental));
            }

            var i = fondamental.Interval;
            Fondamental = i.Fondamental;
            FourthPerfect = i.FourthPerfect;
            FifthPerfect = i.FifthPerfect;
        }

        protected internal ChordSuspendedFourth(Note fondamental, Note fourthPerfect, Note fifthPerfect)
            : base(ChordQualityEnum.MajorSuspendedFourth)
        {
            Fondamental = new NoteFondamental(fondamental);
            FourthPerfect = new NoteFourthPerfect(fourthPerfect);
            FifthPerfect = new NoteFifthPerfect(fifthPerfect);
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality> { Fondamental, FourthPerfect, FifthPerfect };

        public override string Name
            => $"{Fondamental}sus4";

        public override string Details
            => $"Fond: {Fondamental}, 4th: {FourthPerfect}, 5th: {FifthPerfect}";

        public override string Description
            => "Description not added yet.";

        public override string ToString()
        {
            return Name;
        }
    }
}