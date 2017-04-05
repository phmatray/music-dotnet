using MidiMinuit.Music.Core.Scales;

namespace MidiMinuit.SamplePages.ScaleInfo
{
    using System.Collections.ObjectModel;
    using GalaSoft.MvvmLight;

    public class ScaleInfoViewModel : ViewModelBase
    {
        public ObservableCollection<Scale> Scales { get; private set; }

        public ScaleInfoViewModel()
        {
            var allScales = Scale.CreateAll();
            Scales = new ObservableCollection<Scale>(allScales);
        }
    }
}