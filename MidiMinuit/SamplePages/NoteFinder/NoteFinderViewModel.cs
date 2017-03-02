using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Toolkit.Uwp;
using MidiMinuit.Common;
using MidiMinuit.Lib.Core.Chords;
using MidiMinuit.Lib.Core.Notes;
using MidiMinuit.Lib.Instruments.GuitarTunings;
using Windows.Devices.Midi;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace MidiMinuit.SamplePages.NoteFinder
{
    public class NoteFinderViewModel : ViewModelBase
    {
        private string _noteText = "Use your MIDI keyboard";
        private Brush _chordFontBrush = Constants.ThemeResources.SystemControlHighlightAccentBrush;
        private Tuning _tuning = new TuningStandard();
        private ChordBase _chord = ChordBase.GetChord(new Note(NoteNameEnum.C), ChordQualityEnum.Minor);

        public string NoteText
        {
            get { return _noteText; }
            set { Set(ref _noteText, value); }
        }

        public Brush ChordFontBrush
        {
            get { return _chordFontBrush; }
            set { Set(ref _chordFontBrush, value); }
        }

        public Tuning Tuning
        {
            get { return _tuning; }
            set { Set(ref _tuning, value); }
        }

        public ChordBase Chord
        {
            get { return _chord; }
            set { Set(ref _chord, value); }
        }

        public NoteFinderViewModel()
        {
            Messenger.Default.Register<IMidiMessage>(this, async action =>
            {
                await DispatcherHelper.ExecuteOnUIThreadAsync(() =>
                {
                    switch (action.Type)
                    {
                        case MidiMessageType.NoteOn:

                            if (((MidiNoteOnMessage)action).Note < 0 || ((MidiNoteOnMessage)action).Note > 127)
                            {
                                // The range of MIDI notes goes from 0 to 127.
                                return;
                            }

                            NoteText = new Note(((MidiNoteOnMessage) action).Note).ToString();
                            break;
                    }
                });
            });
        }

        public void ChangeColor_OnClick(object sender, RoutedEventArgs e)
        {
            ChordFontBrush = new SolidColorBrush(Colors.Crimson);
        }

        public void ChangeTuning_OnClick(object sender, RoutedEventArgs e)
        {
            Tuning = new TuningTuneDownHalfStep();
        }

        public void ChangeChord_OnClick(object sender, RoutedEventArgs e)
        {
            Chord = ChordBase.GetChord(new Note(NoteNameEnum.E), ChordQualityEnum.MinorDiminishedSeventhDiminished);
        }
    }
}
