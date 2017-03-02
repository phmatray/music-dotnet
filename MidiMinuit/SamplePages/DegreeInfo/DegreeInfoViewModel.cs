using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using MidiMinuit.Lib.Core.Degrees;

namespace MidiMinuit.SamplePages.DegreeInfo
{
    public class DegreeInfoViewModel : ViewModelBase
    {
        public ObservableCollection<DegreeBase> Degrees { get; private set; }

        public DegreeInfoViewModel()
        {
            Degrees = new ObservableCollection<DegreeBase>
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