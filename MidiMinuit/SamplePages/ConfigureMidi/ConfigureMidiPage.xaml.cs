using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using MidiMinuit;
using Windows.Devices.Enumeration;
using Windows.Devices.Midi;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Toolkit.Uwp.SampleApp.SamplePages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ConfigureMidiPage
    {
        private MyMidiDeviceWatcher _inputDeviceWatcher;
        private MyMidiDeviceWatcher _outputDeviceWatcher;
        private MidiInPort _midiInPort;

        /// <summary>
        /// Collection of active MidiOutPorts
        /// </summary>
        private List<IMidiOutPort> _midiOutPorts;

        /// <summary>
        /// Keep track of the current output device (which could also be the GS synth)
        /// </summary>
        private IMidiOutPort _currentMidiOutputDevice;

        public ConfigureMidiPage()
        {
            InitializeComponent();

            // Initialize the list of active MIDI output devices
            this._midiOutPorts = new List<IMidiOutPort>();

            // Set up the MIDI input device watcher
            _inputDeviceWatcher = new MyMidiDeviceWatcher(MidiInPort.GetDeviceSelector(), MidiInPortListBox, Dispatcher);

            // Start watching for devices
            _inputDeviceWatcher.StartWatcher();

            // Set up the MIDI output device watcher
            _outputDeviceWatcher = new MyMidiDeviceWatcher(MidiOutPort.GetDeviceSelector(), MidiOutPortListBox, Dispatcher);

            // Start watching for devices
            _outputDeviceWatcher.StartWatcher();
        }

        private async void MidiInPortListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var deviceInformationCollection = _inputDeviceWatcher.DeviceInformationCollection;

            if (deviceInformationCollection == null)
            {
                return;
            }

            DeviceInformation devInfo = deviceInformationCollection[MidiInPortListBox.SelectedIndex];

            if (devInfo == null)
            {
                return;
            }

            _midiInPort = await MidiInPort.FromIdAsync(devInfo.Id);
            if (_midiInPort == null)
            {
                Debug.WriteLine("Unable to create MidiInPort from input device");
                return;
            }

            _midiInPort.MessageReceived += MidiInPort_MessageReceived;
        }

        private async void MidiInPort_MessageReceived(MidiInPort sender, MidiMessageReceivedEventArgs args)
        {
            IMidiMessage receivedMidiMessage = args.Message;

            Debug.WriteLine(receivedMidiMessage.Timestamp.ToString());

            await Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
            {
                if (receivedMidiMessage.Type == MidiMessageType.NoteOn)
                {
                    var m = (MidiNoteOnMessage)receivedMidiMessage;
                    MidiInConsole.Text = $"{m.Timestamp}, Type: {m.Type}, Channel: {m.Channel}, Note: {m.Note}, Velocity:{m.Velocity}\n" + MidiInConsole.Text;
                }
                else if (receivedMidiMessage.Type == MidiMessageType.NoteOff)
                {
                    var m = (MidiNoteOffMessage)receivedMidiMessage;
                    MidiInConsole.Text = $"{m.Timestamp}, Type: {m.Type}, Channel: {m.Channel}, Note: {m.Note}, Velocity:{m.Velocity}\n" + MidiInConsole.Text;
                }
            });

            _currentMidiOutputDevice?.SendMessage(receivedMidiMessage);
        }

        private async void MidiOutPortListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var deviceInformationCollection = _outputDeviceWatcher.DeviceInformationCollection;

            if (deviceInformationCollection == null)
            {
                return;
            }

            DeviceInformation devInfo = deviceInformationCollection[MidiOutPortListBox.SelectedIndex];

            if (devInfo == null)
            {
                return;
            }

            _currentMidiOutputDevice = await MidiOutPort.FromIdAsync(devInfo.Id);
            if (_currentMidiOutputDevice == null)
            {
                System.Diagnostics.Debug.WriteLine("Unable to create MidiOutPort from output device");
                return;
            }

            // We have successfully created a MidiOutPort; add the device to the list of active devices
            if (!this._midiOutPorts.Contains(this._currentMidiOutputDevice))
            {
                this._midiOutPorts.Add(this._currentMidiOutputDevice);
            }
        }

        private async Task EnumerateMidiInputDevices()
        {
            // Find all input MIDI devices
            string midiInputQueryString = MidiInPort.GetDeviceSelector();
            DeviceInformationCollection midiInputDevices = await DeviceInformation.FindAllAsync(midiInputQueryString);

            MidiInPortListBox.Items.Clear();

            // Return if no external devices are connected
            if (midiInputDevices.Count == 0)
            {
                MidiInPortListBox.Items.Add("No MIDI input devices found!");
                MidiInPortListBox.IsEnabled = false;
                return;
            }

            // Else, add each connected input device to the list
            foreach (DeviceInformation deviceInfo in midiInputDevices)
            {
                MidiInPortListBox.Items.Add(deviceInfo.Name);
                MidiInPortListBox.IsEnabled = true;
            }
        }

        private async Task EnumerateMidiOutputDevices()
        {
            // Find all output MIDI devices
            string midiOutportQueryString = MidiOutPort.GetDeviceSelector();
            DeviceInformationCollection midiOutputDevices = await DeviceInformation.FindAllAsync(midiOutportQueryString);

            MidiOutPortListBox.Items.Clear();

            // Return if no external devices are connected
            if (midiOutputDevices.Count == 0)
            {
                MidiOutPortListBox.Items.Add("No MIDI output devices found!");
                MidiOutPortListBox.IsEnabled = false;
                return;
            }

            // Else, add each connected input device to the list
            foreach (DeviceInformation deviceInfo in midiOutputDevices)
            {
                MidiOutPortListBox.Items.Add(deviceInfo.Name);
                MidiOutPortListBox.IsEnabled = true;
            }
        }

        private void CleanUp()
        {
            _inputDeviceWatcher.StopWatcher();
            _inputDeviceWatcher = null;

            _outputDeviceWatcher.StopWatcher();
            _outputDeviceWatcher = null;

            _midiInPort.MessageReceived += MidiInPort_MessageReceived;
            _midiInPort.Dispose();
            _midiInPort = null;

            _currentMidiOutputDevice.Dispose();
            _currentMidiOutputDevice = null;
        }

        private void SendMidiMessage()
        {
            if (_currentMidiOutputDevice == null)
            {
                return;
            }

            byte channel = 0;
            byte note = 60;
            byte velocity = 127;
            IMidiMessage midiMessageToSend = new MidiNoteOnMessage(channel, note, velocity);

            _currentMidiOutputDevice.SendMessage(midiMessageToSend);
        }

        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            SendMidiMessage();
        }

        private void HamburgerMenu_OnItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HamburgerMenu_OnOptionsItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
