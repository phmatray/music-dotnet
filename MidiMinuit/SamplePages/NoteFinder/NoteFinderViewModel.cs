using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Toolkit.Uwp;
using MidiMinuit.Common;
using MidiMinuit.Lib.Chords.Core.Chords.Base;
using MidiMinuit.Lib.Chords.Core.Chords.Enum;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;
using MidiMinuit.Lib.Chords.Core.Tunings;
using MidiMinuit.Lib.Chords.Core.Tunings.Base;
using Windows.Devices.Midi;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace MidiMinuit.SamplePages.NoteFinder
{
    public class NoteFinderViewModel : ViewModelBase
    {
        private string _noteText = "Use your MIDI keyboard";

        public string NoteText
        {
            get { return _noteText; }
            set { Set(ref _noteText, value); }
        }

        private RelayCommand _changeColorCommand;

        public RelayCommand ChangeColorCommand
        {
            get
            {
                if (_changeColorCommand == null)
                {
                    _changeColorCommand = new RelayCommand(() =>
                    {
                        ChordFontBrush = new SolidColorBrush(Colors.Crimson);
                    });
                }

                return _changeColorCommand;
            }
        }

        private Brush _chordFontBrush = Constants.ThemeResources.SystemControlHighlightAccentBrush;

        public Brush ChordFontBrush
        {
            get { return _chordFontBrush; }
            set { Set(ref _chordFontBrush, value); }
        }

        private RelayCommand _changeTuningCommand;

        public RelayCommand ChangeTuningCommand
        {
            get
            {
                if (_changeTuningCommand == null)
                {
                    _changeTuningCommand = new RelayCommand(() =>
                    {
                        Tuning = new TuningTuneDownHalfStep();
                    });
                }

                return _changeTuningCommand;
            }
        }

        private Tuning _tuning = new TuningStandard();

        public Tuning Tuning
        {
            get { return _tuning; }
            set { Set(ref _tuning, value); }
        }

        private RelayCommand _changeChordCommand;

        public RelayCommand ChangeChordCommand
        {
            get
            {
                if (_changeChordCommand == null)
                {
                    _changeChordCommand = new RelayCommand(() =>
                    {
                        Chord = Chord.GetChord(Note.New(NoteName.E), ChordQuality.MinorDiminishedSeventhDiminished);
                    });
                }

                return _changeChordCommand;
            }
        }

        private Chord _chord = Chord.GetChord(Note.New(NoteName.C), ChordQuality.Minor);

        public Chord Chord
        {
            get
            {
                return _chord;
            }

            set
            {
                Set(ref _chord, value);
                RaisePropertyChanged(nameof(ChordName));
                RaisePropertyChanged(nameof(ChordFormat));
                RaisePropertyChanged(nameof(ChordDescription));
            }
        }

        public string ChordName
            => Chord?.Name;

        public string ChordFormat
            => Chord?.Details;

        public string ChordDescription
            => Chord?.Description;












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

                            NoteText = Note.New(((MidiNoteOnMessage) action).Note).ToString();
                            break;
                    }
                });
            });
        }
    }
}
