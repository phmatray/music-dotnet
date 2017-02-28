using Windows.Devices.Midi;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Toolkit.Uwp;
using MidiMinuit.Lib.Chords.Core.Notes.Base;
using MidiMinuit.Lib.Chords.Core.Notes.Enum;

namespace MidiMinuit.SamplePages.NoteFinder
{
    public class NoteFinderViewModel : ViewModelBase
    {
        private string _noteText = "Use your keyboard";

        public string NoteText
        {
            get { return _noteText; }
            set { Set(ref _noteText, value); }
        }

        public NoteFinderViewModel()
        {
            Messenger.Default.Register<IMidiMessage>(this, async action =>
            {
                await DispatcherHelper.ExecuteOnUIThreadAsync(() =>
                {
                    switch (action.Type)
                    {
                        //case MidiMessageType.NoteOff:
                        //    Note = "Note";
                        //    break;
                        case MidiMessageType.NoteOn:

                            if (((MidiNoteOnMessage) action).Note < 0 || ((MidiNoteOnMessage) action).Note > 127)
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
