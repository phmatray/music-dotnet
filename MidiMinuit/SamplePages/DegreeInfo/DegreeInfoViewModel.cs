using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using MidiMinuit.Music.Core.Degrees;

namespace MidiMinuit.SamplePages.DegreeInfo
{
    public class DegreeInfoViewModel : ViewModelBase
    {
        public ObservableCollection<Degree> Degrees { get; private set; }

        public DegreeInfoViewModel()
        {
            Degrees = new ObservableCollection<Degree>
            {
                new Degree1(),
                new Degree2(),
                new Degree3(),
                new Degree4(),
                new Degree5(),
                new Degree6(),
                new Degree7(),
                new Degree8()
            };
        }
    }
}