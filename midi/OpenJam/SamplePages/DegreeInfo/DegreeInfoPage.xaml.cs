namespace OpenJam.SamplePages.DegreeInfo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DegreeInfoPage
    {
        public DegreeInfoPage()
        {
            InitializeComponent();

            ViewModel = ViewModelLocator.Instance.DegreeInfoInstance;
        }

        public DegreeInfoViewModel ViewModel { get; set; }
    }
}
