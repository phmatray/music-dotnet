using MidiMinuit.Music.Core.Intervals;
using MidiMinuit.Music.Core.NoteAccidentals;
using MidiMinuit.Music.Core.NoteNames;
using MidiMinuit.Music.Core.Notes;

namespace MidiMinuit.SamplePages.IntervalCalculator
{
    using GalaSoft.MvvmLight;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public class IntervalCalculatorViewModel : ViewModelBase
    {
        public IntervalCalculatorViewModel()
        {
            StepName = new StepNameC();
            NoteAccidental = new NoteAccidentalNatural();
            var note = new Pitch(StepName, NoteAccidental);
            Interval = new IntervalPerfectFifth(note);
        }

        private StepName _stepName;
        private NoteAccidental _noteAccidental;
        private Interval _interval;

        public StepName StepName
        {
            get { return _stepName; }
            set { Set(ref _stepName, value); }
        }

        public NoteAccidental NoteAccidental
        {
            get { return _noteAccidental; }
            set { Set(ref _noteAccidental, value); }
        }

        public Interval Interval
        {
            get { return _interval; }
            set { Set(ref _interval, value); }
        }

        public StepName StepNameC { get; } = new StepNameC();
        public StepName StepNameD { get; } = new StepNameD();
        public StepName StepNameE { get; } = new StepNameE();
        public StepName StepNameF { get; } = new StepNameF();
        public StepName StepNameG { get; } = new StepNameG();
        public StepName StepNameA { get; } = new StepNameA();
        public StepName StepNameB { get; } = new StepNameB();

        public NoteAccidental NoteAccidentalDoubleFlat { get; } = new NoteAccidentalDoubleFlat();
        public NoteAccidental NoteAccidentalFlat { get; } = new NoteAccidentalFlat();
        public NoteAccidental NoteAccidentalNatural { get; } = new NoteAccidentalNatural();
        public NoteAccidental NoteAccidentalSharp { get; } = new NoteAccidentalSharp();
        public NoteAccidental NoteAccidentalDoubleSharp { get; } = new NoteAccidentalDoubleSharp();

        public Interval IntervalA2 { get; } = new IntervalAugmentedSecond();
        public Interval IntervalA3 { get; } = new IntervalAugmentedThird();
        public Interval IntervalA4 { get; } = new IntervalAugmentedFourth();
        public Interval IntervalA5 { get; } = new IntervalAugmentedFifth();
        public Interval IntervalA6 { get; } = new IntervalAugmentedSixth();
        public Interval IntervalA7 { get; } = new IntervalAugmentedSeventh();
        public Interval IntervalA8 { get; } = new IntervalAugmentedOctave();
        public Interval IntervalM2 { get; } = new IntervalMajorSecond();
        public Interval IntervalM3 { get; } = new IntervalMajorThird();
        public Interval IntervalP4 { get; } = new IntervalPerfectFourth();
        public Interval IntervalP5 { get; } = new IntervalPerfectFifth();
        public Interval IntervalM6 { get; } = new IntervalMajorSixth();
        public Interval IntervalM7 { get; } = new IntervalMajorSeventh();
        public Interval IntervalP8 { get; } = new IntervalPerfectOctave();
        public Interval IntervalMin2 { get; } = new IntervalMinorSecond();
        public Interval IntervalMin3 { get; } = new IntervalMinorThird();
        public Interval IntervalMin6 { get; } = new IntervalMinorSixth();
        public Interval IntervalMin7 { get; } = new IntervalMinorSeventh();
        public Interval IntervalDim2 { get; } = new IntervalDiminishedSecond();
        public Interval IntervalDim3 { get; } = new IntervalDiminishedThird();
        public Interval IntervalDim4 { get; } = new IntervalDiminishedFourth();
        public Interval IntervalDim5 { get; } = new IntervalDiminishedFifth();
        public Interval IntervalDim6 { get; } = new IntervalDiminishedSixth();
        public Interval IntervalDim7 { get; } = new IntervalDiminishedSeventh();
        public Interval IntervalDim8 { get; } = new IntervalDiminishedOctave();

        public void NoteName_OnChecked(object sender, RoutedEventArgs e)
        {
            StepName = (sender as RadioButton)?.Tag as StepName;
            Interval.LowerPitch = new Pitch(StepName, NoteAccidental);
            RaisePropertyChanged(() => Interval);
        }

        public void NoteAccidental_OnChecked(object sender, RoutedEventArgs e)
        {
            NoteAccidental = (sender as RadioButton)?.Tag as NoteAccidental;
            Interval.LowerPitch = new Pitch(StepName, NoteAccidental);
            RaisePropertyChanged(() => Interval);
        }

        public void Interval_OnChecked(object sender, RoutedEventArgs e)
        {
            var interval = (sender as RadioButton)?.Tag as Interval;
            interval.LowerPitch = new Pitch(StepName, NoteAccidental);
            Interval = interval;
        }
    }
}