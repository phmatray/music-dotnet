using GalaSoft.MvvmLight;

namespace MidiMinuit.SamplePages.ConfigureMidi
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