using System.Collections.ObjectModel;
using System.Linq;
using OpenJam.Music.Core;
using OpenJam.Music.Instruments;

namespace OpenJam.Music.Tools
{
    public static class MusicContext
    {
        private static ReadOnlyCollection<Chord> _chords;
        private static ReadOnlyCollection<Degree> _degrees;
        private static ReadOnlyCollection<IntervalModifier> _intervalModifiers;
        private static ReadOnlyCollection<Interval> _intervals;
        private static ReadOnlyCollection<IntervalSimple> _intervalSimples;
        private static ReadOnlyCollection<IntervalCompound> _intervalCompounds;
        private static ReadOnlyCollection<DiatonicInterval> _diatonicIntervals;
        private static ReadOnlyCollection<Step> _steps;
        private static ReadOnlyCollection<Pitch> _pitches;
        private static ReadOnlyCollection<Scale> _scales;
        private static ReadOnlyCollection<StepAccidental> _stepAccidentals;
        private static ReadOnlyCollection<StepName> _stepNames;
        private static ReadOnlyCollection<GuitarTuning> _guitarTunings;

        public static ReadOnlyCollection<Chord> Chords
            => _chords ?? (_chords =
                   Chord.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<Degree> Degrees
            => _degrees ?? (_degrees =
                   Degree.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<IntervalModifier> IntervalModifiers
            => _intervalModifiers ?? (_intervalModifiers =
                   IntervalModifier.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<Interval> Intervals
            => _intervals ?? (_intervals =
                   Interval.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<IntervalSimple> IntervalSimples
            => _intervalSimples ?? (_intervalSimples =
                   Interval.CreateAll()
                       .OfType<IntervalSimple>()
                       .ToList()
                       .AsReadOnly());

        public static ReadOnlyCollection<IntervalCompound> IntervalCompounds
            => _intervalCompounds ?? (_intervalCompounds =
                   Interval.CreateAll()
                       .OfType<IntervalCompound>()
                       .ToList()
                       .AsReadOnly());

        public static ReadOnlyCollection<DiatonicInterval> DiatonicIntervals
            => _diatonicIntervals ?? (_diatonicIntervals =
                   DiatonicInterval.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<Step> Steps
            => _steps ?? (_steps =
                   Step.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<Pitch> Pitches
            => _pitches ?? (_pitches =
                   Pitch.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<Scale> Scales
            => _scales ?? (_scales =
                   Scale.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<StepAccidental> StepAccidentals
            => _stepAccidentals ?? (_stepAccidentals =
                   StepAccidental.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<StepName> StepNames
            => _stepNames ?? (_stepNames =
                   StepName.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<GuitarTuning> GuitarTunings
            => _guitarTunings ?? (_guitarTunings =
                   GuitarTuning.CreateAll().AsReadOnly());
    }
}