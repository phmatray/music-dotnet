using MidiMinuit.Music.Core;

namespace MidiMinuit.SamplePages.IntervalCalculator
{
    using GalaSoft.MvvmLight;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            StepName = new StepNameC();
            StepAccidental = new StepAccidentalNatural();
            var note = new Pitch(StepName, StepAccidental);
            Interval = new IntervalPerfectFifth(note);
        }

        private StepName _stepName;
        private StepAccidental _stepAccidental;
        private Interval _interval;

        public StepName StepName
        {
            get { return _stepName; }
            set { Set(ref _stepName, value); }
        }

        public StepAccidental StepAccidental
        {
            get { return _stepAccidental; }
            set { Set(ref _stepAccidental, value); }
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

        public StepAccidental StepAccidentalDoubleFlat { get; } = new StepAccidentalDoubleFlat();
        public StepAccidental StepAccidentalFlat { get; } = new StepAccidentalFlat();
        public StepAccidental StepAccidentalNatural { get; } = new StepAccidentalNatural();
        public StepAccidental StepAccidentalSharp { get; } = new StepAccidentalSharp();
        public StepAccidental StepAccidentalDoubleSharp { get; } = new StepAccidentalDoubleSharp();

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
            Interval.LowerPitch = new Pitch(StepName, StepAccidental);
            RaisePropertyChanged(() => Interval);
        }

        public void NoteAccidental_OnChecked(object sender, RoutedEventArgs e)
        {
            StepAccidental = (sender as RadioButton)?.Tag as StepAccidental;
            Interval.LowerPitch = new Pitch(StepName, StepAccidental);
            RaisePropertyChanged(() => Interval);
        }

        public void Interval_OnChecked(object sender, RoutedEventArgs e)
        {
            var interval = (sender as RadioButton)?.Tag as Interval;
            interval.LowerPitch = new Pitch(StepName, StepAccidental);
            Interval = interval;
        }
    }
}