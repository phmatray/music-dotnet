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
using MidiMinuit.SamplePages.ScaleInfo;

namespace MidiMinuit.SamplePages.IntervalCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IntervalCalculatorPage
    {
        public IntervalCalculatorPage()
        {
            InitializeComponent();

            ViewModel = ViewModelLocator.Instance.IntervalCalculatorInstance;
        }

        public IntervalCalculatorViewModel ViewModel { get; set; }

        private void IntervalCalculatorPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            RadioButtonNoteNameC.IsChecked = true;
            RadioButtonNoteAccidentalNatural.IsChecked = true;
            RadioButtonIntervalPerfectFifth.IsChecked = true;
        }
    }
}
