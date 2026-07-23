using GalaSoft.MvvmLight;

namespace OpenJam.SamplePages.ConfigureMidi
{
    public class ConfigureMidiViewModel : ViewModelBase
    {
        public string Hello { get; set; }

        public ConfigureMidiViewModel()
        {
            Hello = "Hello Philippe";
        }
    }
}