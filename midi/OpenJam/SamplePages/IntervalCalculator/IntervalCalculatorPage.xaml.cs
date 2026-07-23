using Windows.UI.Xaml;

namespace OpenJam.SamplePages.IntervalCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class IntervalCalculatorPage
    {
        public IntervalCalculatorPage()
        {
            InitializeComponent();

            ViewModel = ViewModelLocator.Instance.IntervalCalculatorInstance;
        }

        public IntervalCalculatorViewModel ViewModel { get; set; }

        private void IntervalCalculatorPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            RadioButtonNoteNameC.IsChecked = true;
            RadioButtonNoteAccidentalNatural.IsChecked = true;
            RadioButtonIntervalPerfectFifth.IsChecked = true;
        }
    }
}
