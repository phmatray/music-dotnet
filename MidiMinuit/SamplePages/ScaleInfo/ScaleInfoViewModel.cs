using MidiMinuit.Music.Core.Pitches;
using MidiMinuit.Music.Core.Scales;
using MidiMinuit.Music.Core.StepNames;

namespace MidiMinuit.SamplePages.ScaleInfo
{
    using System.Collections.ObjectModel;
    using GalaSoft.MvvmLight;

    public class ScaleInfoViewModel : ViewModelBase
    {
        public ObservableCollection<Scale> Scales { get; private set; }

        public ScaleInfoViewModel()
        {
            var allScales = new ScaleRepository().CreateAllScales(new Pitch(StepNameAlias.C));
            Scales = new ObservableCollection<Scale>(allScales);
        }
    }
}