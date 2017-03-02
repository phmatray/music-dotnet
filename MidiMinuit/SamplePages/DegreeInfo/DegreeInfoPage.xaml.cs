using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;
using MidiMinuit.Helpers;
using Windows.Devices.Enumeration;
using Windows.Devices.Midi;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace MidiMinuit.SamplePages.DegreeInfo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DegreeInfoPage
    {
        public DegreeInfoPage()
        {
            InitializeComponent();

            ViewModel = ViewModelLocator.Instance.DegreeInfoInstance;
        }

        public DegreeInfoViewModel ViewModel { get; set; }
    }
}
