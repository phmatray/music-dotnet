namespace OpenJam.SamplePages.ScaleInfo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ScaleInfoPage
    {
        public ScaleInfoPage()
        {
            InitializeComponent();

            ViewModel = ViewModelLocator.Instance.ScaleInfoInstance;
        }

        public ScaleInfoViewModel ViewModel { get; set; }
    }
}
