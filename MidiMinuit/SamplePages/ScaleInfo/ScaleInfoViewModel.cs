using MidiMinuit.Music.Core.Notes;
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
            var allScales = new ScaleFactory().CreateAllScales(new Pitch());
            Scales = new ObservableCollection<Scale>(allScales);
        }
    }
}