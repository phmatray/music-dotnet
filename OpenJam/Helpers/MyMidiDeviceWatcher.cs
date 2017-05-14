using System;
using System.Linq;
using Windows.Devices.Enumeration;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

namespace OpenJam.Helpers
{
    public class MyMidiDeviceWatcher
    {
        private DeviceWatcher _deviceWatcher;
        private string _deviceSelectorString;
        private ListBox _deviceListBox;
        private CoreDispatcher _coreDispatcher;

        public MyMidiDeviceWatcher(string midiDeviceSelectorString, ListBox midiDeviceListBox, CoreDispatcher dispatcher)
        {
            _deviceListBox = midiDeviceListBox;
            _coreDispatcher = dispatcher;

            _deviceSelectorString = midiDeviceSelectorString;

            _deviceWatcher = DeviceInformation.CreateWatcher(_deviceSelectorString);
            _deviceWatcher.Added += DeviceWatcher_Added;
            _deviceWatcher.Removed += DeviceWatcher_Removed;
            _deviceWatcher.Updated += DeviceWatcher_Updated;
            _deviceWatcher.EnumerationCompleted += DeviceWatcher_EnumerationCompleted;
        }

        ~MyMidiDeviceWatcher()
        {
            _deviceWatcher.Added -= DeviceWatcher_Added;
            _deviceWatcher.Removed -= DeviceWatcher_Removed;
            _deviceWatcher.Updated -= DeviceWatcher_Updated;

            _deviceWatcher = null;
        }

        public DeviceInformationCollection DeviceInformationCollection { get; set; }

        public void StartWatcher()
        {
            _deviceWatcher.Start();
        }

        public void StopWatcher()
        {
            _deviceWatcher.Stop();
        }

        private async void DeviceWatcher_Removed(DeviceWatcher sender, DeviceInformationUpdate args)
            => await _coreDispatcher.RunAsync(CoreDispatcherPriority.High, UpdateDevices);

        private async void DeviceWatcher_Added(DeviceWatcher sender, DeviceInformation args)
            => await _coreDispatcher.RunAsync(CoreDispatcherPriority.High, UpdateDevices);

        private async void DeviceWatcher_EnumerationCompleted(DeviceWatcher sender, object args)
            => await _coreDispatcher.RunAsync(CoreDispatcherPriority.High, UpdateDevices);

        private async void DeviceWatcher_Updated(DeviceWatcher sender, DeviceInformationUpdate args)
            => await _coreDispatcher.RunAsync(CoreDispatcherPriority.High, UpdateDevices);

        private async void UpdateDevices()
        {
            // Get a list of all MIDI devices
            DeviceInformationCollection = await DeviceInformation.FindAllAsync(_deviceSelectorString);

            _deviceListBox.Items.Clear();

            if (!DeviceInformationCollection.Any())
            {
                _deviceListBox.Items.Add("No MIDI devices found!");
            }

            foreach (var deviceInformation in DeviceInformationCollection)
            {
                _deviceListBox.Items.Add(deviceInformation.Name);
            }
        }
    }
}
