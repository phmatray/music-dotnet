namespace MidiMinuit.Lib.Core.Scales
{
    using System;
    using System.Collections.Generic;
    using MidiMinuit.Lib.Core.Intervals;
    using MidiMinuit.Lib.Core.Notes;

    public class ScaleModeLydianAdded : ScaleBase
    {
        public IntervalPerfectUnison Fondamental { get; }

        public IntervalMajorSecond SecondMajor { get; }

        public IntervalMajorThird ThirdMajor { get; }

        public IntervalAugmentedEleventh Eleventh { get; }

        public IntervalAugmentedFifth FifthAugmented { get; }

        public IntervalMajorSixth SixthMajor { get; }

        public IntervalMajorSeventh SeventhMajor { get; }

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
            Eleventh = i.EleventhAugmented;
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