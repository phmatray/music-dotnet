namespace MidiMinuit.SamplePages.ScaleInfo
{
    using System.Collections.ObjectModel;
    using GalaSoft.MvvmLight;
    using MidiMinuit.Lib.Core.Notes;
    using MidiMinuit.Lib.Core.Scales;

    public class ScaleInfoViewModel : ViewModelBase
    {
        public ObservableCollection<Scale> Scales { get; private set; }

        public ScaleInfoViewModel()
        {
            var allScales = new ScaleFactory().CreateAllScales(new Note());
            Scales = new ObservableCollection<Scale>(allScales);
        }
    }
}