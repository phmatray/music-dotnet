using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using OpenJam.Music.Core;

namespace OpenJam.SamplePages.ScaleInfo
{
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