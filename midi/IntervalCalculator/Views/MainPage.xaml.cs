using Windows.UI.Xaml;
using IntervalCalculator.ViewModels;

namespace IntervalCalculator.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            ViewModel = ViewModelLocator.Instance.MainInstance;

            InitializeComponent();
        }

        public MainViewModel ViewModel { get; set; }

        private void IntervalCalculatorPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            RadioButtonNoteNameC.IsChecked = true;
            RadioButtonNoteAccidentalNatural.IsChecked = true;
            RadioButtonIntervalPerfectFifth.IsChecked = true;
            RadioButtonIntervalInversionUp.IsChecked = true;
        }
    }
}
