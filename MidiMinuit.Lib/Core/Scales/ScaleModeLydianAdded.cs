using System;
using System.Collections.Generic;
using MidiMinuit.Lib.Core.Intervals;
using MidiMinuit.Lib.Core.Notes;

namespace MidiMinuit.Lib.Core.Scales
{
    public class ScaleModeLydianAdded : ScaleBase
    {
        public NoteFondamental Fondamental { get; }

        public NoteSecondMajor SecondMajor { get; }

        public NoteThirdMajor ThirdMajor { get; }

        public IntervalAugmentedEleventh Eleventh { get; }

        public NoteFifthAugmented FifthAugmented { get; }

        public NoteSixthMajor SixthMajor { get; }

        public NoteSeventhMajor SeventhMajor { get; }

        public ScaleModeLydianAdded(Note key)
            : base(ScaleTypeEnum.ModeLydianAdded)
        {
            // mode lydien augmenté : T 2M 3M #11 #5 6M 7M
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var i = key.Interval;
            Fondamental = i.Fondamental;
            SecondMajor = i.SecondMajor;
            ThirdMajor = i.ThirdMajor;
            Eleventh = i.Eleventh;
            FifthAugmented = i.FifthAugmented;
            SixthMajor = i.SixthMajor;
            SeventhMajor = i.SeventhMajor;
        }

        public override List<NoteQuality> Notes
            => new List<NoteQuality>
            {
                Fondamental,
                SecondMajor,
                ThirdMajor,
                Eleventh,
                FifthAugmented,
                SixthMajor,
                SeventhMajor
            };

        public override string Name
            => $"Mode Lydian Added";

        public override string ToString()
        {
            return Name;
        }
    }
}