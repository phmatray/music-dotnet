namespace MidiMinuit.SamplePages.IntervalCalculator
{
    using GalaSoft.MvvmLight;
    using Music.Core;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            _stepName = new StepNameC();
            _stepAccidental = new StepAccidentalNatural();
            _interval = new IntervalPerfectFifth(new Pitch(_stepName, _stepAccidental));
            _intervalInversion = _interval.InverseOctaveUp();
        }

        private StepName _stepName;
        private StepAccidental _stepAccidental;
        private Interval _interval;
        private Interval _intervalInversion;
        private bool _isInversionUpChecked;
        private bool _isInversionDownChecked;

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
            Interval.StartingPitch = new Pitch(StepName, StepAccidental);
            _intervalInversion = _interval.InverseOctaveUp();
            RaisePropertyChanged(() => Interval);
        }

        public void NoteAccidental_OnChecked(object sender, RoutedEventArgs e)
        {
            StepAccidental = (sender as RadioButton)?.Tag as StepAccidental;
            Interval.StartingPitch = new Pitch(StepName, StepAccidental);
            _intervalInversion = _interval.InverseOctaveUp();
            RaisePropertyChanged(() => Interval);
        }

        public void Interval_OnChecked(object sender, RoutedEventArgs e)
        {
            var interval = (sender as RadioButton)?.Tag as Interval;
            interval.StartingPitch = new Pitch(StepName, StepAccidental);
            _intervalInversion = _interval.InverseOctaveUp();

            Interval = _isInversionUpChecked
                ? interval
                : _intervalInversion;
        }

        public void IntervalInversionUp_OnChecked(object sender, RoutedEventArgs e)
        {
            _isInversionUpChecked = true;
            _isInversionDownChecked = false;

            if (_interval == _intervalInversion)
            {
                Interval = Interval.InverseOctaveDown();
            }
        }

        public void IntervalInversionDown_OnChecked(object sender, RoutedEventArgs e)
        {
            _isInversionUpChecked = false;
            _isInversionDownChecked = true;

            if (_interval != _intervalInversion)
            {
                Interval = _intervalInversion;
            }
        }
    }
}