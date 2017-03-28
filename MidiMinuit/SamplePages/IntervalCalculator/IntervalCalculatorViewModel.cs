using System.Linq;

namespace MidiMinuit.SamplePages.IntervalCalculator
{
    using GalaSoft.MvvmLight;
    using Lib.Core.Intervals;
    using Lib.Core.NoteAccidentals;
    using Lib.Core.NoteNames;
    using Lib.Core.Notes;
    using Windows.UI.Xaml;

    public class IntervalCalculatorViewModel : ViewModelBase
    {
        public IntervalCalculatorViewModel()
        {
            NoteName = new NoteNameC();
            NoteAccidental = new NoteAccidentalNatural();
            var note = new Note(NoteName, NoteAccidental);
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

        private void RefreshNoteName(NoteName name)
        {
            NoteName = name;
            var note = new Note(NoteName, NoteAccidental);
            Interval.LowerNote = note;
            RaisePropertyChanged(() => Interval);
        }

        private void RefreshNoteAccidental(NoteAccidental accidental)
        {
            NoteAccidental = accidental;
            var note = new Note(NoteName, NoteAccidental);
            Interval.LowerNote = note;
            RaisePropertyChanged(() => Interval);
        }

        private void RefreshInterval(Interval interval)
        {
            interval.LowerNote = new Note(NoteName, NoteAccidental);
            Interval = interval;
        }

        public void NoteNameC_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteName(new NoteNameC());

        public void NoteNameD_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteName(new NoteNameD());

        public void NoteNameE_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteName(new NoteNameE());

        public void NoteNameF_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteName(new NoteNameF());

        public void NoteNameG_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteName(new NoteNameG());

        public void NoteNameA_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteName(new NoteNameA());

        public void NoteNameB_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteName(new NoteNameB());

        public void NoteAccidentalNatural_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteAccidental(new NoteAccidentalNatural());

        public void NoteAccidentalFlat_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteAccidental(new NoteAccidentalFlat());

        public void NoteAccidentalSharp_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteAccidental(new NoteAccidentalSharp());

        public void NoteAccidentalDoubleFlat_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteAccidental(new NoteAccidentalDoubleFlat());

        public void NoteAccidentalDoubleSharp_OnClick(object sender, RoutedEventArgs e)
            => RefreshNoteAccidental(new NoteAccidentalDoubleSharp());

        public void IntervalA2_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalAugmentedSecond());

        public void IntervalA3_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalAugmentedThird());

        public void IntervalA4_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalAugmentedFourth());

        public void IntervalA5_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalAugmentedFifth());

        public void IntervalA6_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalAugmentedSixth());

        public void IntervalA7_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalAugmentedSeventh());

        public void IntervalA8_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalAugmentedOctave());

        public void IntervalM2_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalMajorSecond());

        public void IntervalM3_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalMajorThird());

        public void IntervalP4_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalPerfectFourth());

        public void IntervalP5_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalPerfectFifth());

        public void IntervalM6_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalMajorSixth());

        public void IntervalM7_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalMajorSeventh());

        public void IntervalP8_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalPerfectOctave());

        public void IntervalMin2_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalMinorSecond());

        public void IntervalMin3_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalMinorThird());

        public void IntervalMin6_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalMinorSixth());

        public void IntervalMin7_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalMinorSeventh());

        public void IntervalDim2_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalDiminishedSecond());

        public void IntervalDim3_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalDiminishedThird());

        public void IntervalDim4_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalDiminishedFourth());

        public void IntervalDim5_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalDiminishedFifth());

        public void IntervalDim6_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalDiminishedSixth());

        public void IntervalDim7_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalDiminishedSeventh());

        public void IntervalDim8_OnClick(object sender, RoutedEventArgs e)
            => RefreshInterval(new IntervalDiminishedOctave());
    }
}