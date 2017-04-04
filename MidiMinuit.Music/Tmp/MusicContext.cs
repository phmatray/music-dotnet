using System.Collections.ObjectModel;
using System.Linq;
using MidiMinuit.Music.Core.Chords;
using MidiMinuit.Music.Core.Degrees;
using MidiMinuit.Music.Core.IntervalModifiers;
using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.IntervalSteps;
using MidiMinuit.Music.Core.Pitches;
using MidiMinuit.Music.Core.Scales;
using MidiMinuit.Music.Core.StepAccidentals;
using MidiMinuit.Music.Core.StepNames;
using MidiMinuit.Music.Instruments.GuitarTunings;

namespace MidiMinuit.Music.Tmp
{
    public class MusicContextTest
    {
        public MusicContextTest()
        {
            var intervals = MusicContext.Intervals.Where(x => x.Semitones == 5).ToList();
            var chordGMajor = MusicContext.Chords.Where(x => x.Fondamental.UpperPitch == Pitch.C4).ToList();
            StepName stepName = MusicContext.StepNames.Single(x => x.Name == "C");
        }
    }

    public static class MusicContext
    {
        private static ReadOnlyCollection<Chord> _chords;
        private static ReadOnlyCollection<Degree> _degrees;
        private static ReadOnlyCollection<IntervalModifier> _intervalModifiers;
        private static ReadOnlyCollection<Interval> _intervals;
        private static ReadOnlyCollection<IntervalStep> _intervalSteps;
        private static ReadOnlyCollection<Pitch> _pitches;
        private static ReadOnlyCollection<Scale> _scales;
        private static ReadOnlyCollection<StepAccidental> _stepAccidentals;
        private static ReadOnlyCollection<StepName> _stepNames;
        private static ReadOnlyCollection<GuitarTuning> _guitarTunings;

        public static ReadOnlyCollection<Chord> Chords
            => _chords ?? (_chords = Chord.CreateAll(Pitch.C4).AsReadOnly());

        public static ReadOnlyCollection<Degree> Degrees
            => _degrees ?? (_degrees = Degree.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<IntervalModifier> IntervalModifiers
            => _intervalModifiers ?? (_intervalModifiers = IntervalModifier.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<Interval> Intervals
            => _intervals ?? (_intervals = Interval.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<IntervalStep> IntervalSteps
            => _intervalSteps ?? (_intervalSteps = IntervalStep.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<Pitch> Pitches
            => _pitches ?? (_pitches = Pitch.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<Scale> Scales
            => _scales ?? (_scales = Scale.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<StepAccidental> StepAccidentals
            => _stepAccidentals ?? (_stepAccidentals = StepAccidental.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<StepName> StepNames
            => _stepNames ?? (_stepNames = StepName.CreateAll().AsReadOnly());

        public static ReadOnlyCollection<GuitarTuning> GuitarTunings
            => _guitarTunings ?? (_guitarTunings = GuitarTuning.CreateAll().AsReadOnly());

        ////[Obsolete]
        ////public static List<IntervalStep> GetIntervalStepByAbbreviation(string abbreviation)
        ////    => IntervalSteps
        ////        .Where(x => x.Abbreviation == abbreviation)
        ////        .ToList();

        ////[Obsolete]
        ////public static IntervalStep GetIntervalStep(IntervalStepAlias step)
        ////    => IntervalSteps
        ////        .Single(x => x.Alias == step);

        ////[Obsolete]
        ////public static IntervalStep Get(int number)
        ////    => IntervalSteps
        ////        .Single(x => x.Alias == (IntervalStepAlias)number);

        ////[Obsolete]
        ////public static List<IntervalModifier> GetByAbbreviation(string abbreviation)
        ////    => _intervalModifiers
        ////        .Where(x => x.Abbreviation == abbreviation)
        ////        .ToList();

        ////[Obsolete]
        ////public static IntervalModifier Get(IntervalModifierAlias modifier)
        ////    => _intervalModifiers
        ////        .Single(x => x.Alias == modifier);

        ////[Obsolete]
        ////public static List<Interval> GetByNumber(IntervalStep step)
        ////    => _intervals
        ////        .Where(x => x.Step == step)
        ////        .ToList();

        ////[Obsolete]
        ////public static List<Interval> GetByModifier(IntervalModifier modifier)
        ////    => _intervals
        ////        .Where(x => x.Modifier == modifier)
        ////        .ToList();

        ////[Obsolete]
        ////public static List<Interval> GetBySpanning(IntervalSpanning spanning)
        ////    => _intervals
        ////        .Where(x => x.Spanning == spanning)
        ////        .ToList();

        ////[Obsolete]
        ////public static List<Interval> GetByAbbreviation(string abbreviation)
        ////    => _intervals
        ////        .Where(x => x.Abbreviations.First() == abbreviation)
        ////        .ToList();

        ////[Obsolete]
        ////public static List<Interval> GetBySemitones(int semitones)
        ////    => _intervals
        ////        .Where(x => x.Semitones == semitones)
        ////        .ToList();

        ////[Obsolete]
        ////public static Interval Get(IntervalAlias interval)
        ////    => _intervals
        ////        .Single(x => x.Alias == interval);

        ////[Obsolete]
        ////public static StepAccidental Get(NoteAccidentalAlias accidental)
        ////    => _noteAccidentals
        ////        .Single(x => x.Alias == accidental);

        ////[Obsolete]
        ////public static StepName Get(StepNameAlias name)
        ////    => _noteNames
        ////        .Single(x => x.Alias == name);

        ////[Obsolete]
        ////public static StepName GetByOrder(int order)
        ////    => _noteNames
        ////        .Single(x => x.StepNumber == order);
    }
}