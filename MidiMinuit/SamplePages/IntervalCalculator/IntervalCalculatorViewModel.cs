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
            NoteName = new NoteNameC();
            NoteAccidental = new NoteAccidentalNatural();
            var note = new Pitch(NoteName, NoteAccidental);
            Interval = new IntervalPerfectFifth(note);
        }

        private NoteName _noteName;
        private NoteAccidental _noteAccidental;
        private Interval _interval;

        public NoteName NoteName
        {
            get { return _noteName; }
            set { Set(ref _noteName, value); }
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

        public NoteName NoteNameC { get; } = new NoteNameC();
        public NoteName NoteNameD { get; } = new NoteNameD();
        public NoteName NoteNameE { get; } = new NoteNameE();
        public NoteName NoteNameF { get; } = new NoteNameF();
        public NoteName NoteNameG { get; } = new NoteNameG();
        public NoteName NoteNameA { get; } = new NoteNameA();
        public NoteName NoteNameB { get; } = new NoteNameB();

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
            NoteName = (sender as RadioButton)?.Tag as NoteName;
            Interval.LowerPitch = new Pitch(NoteName, NoteAccidental);
            RaisePropertyChanged(() => Interval);
        }

        public void NoteAccidental_OnChecked(object sender, RoutedEventArgs e)
        {
            NoteAccidental = (sender as RadioButton)?.Tag as NoteAccidental;
            Interval.LowerPitch = new Pitch(NoteName, NoteAccidental);
            RaisePropertyChanged(() => Interval);
        }

        public void Interval_OnChecked(object sender, RoutedEventArgs e)
        {
            var interval = (sender as RadioButton)?.Tag as Interval;
            interval.LowerPitch = new Pitch(NoteName, NoteAccidental);
            Interval = interval;
        }
    }
}