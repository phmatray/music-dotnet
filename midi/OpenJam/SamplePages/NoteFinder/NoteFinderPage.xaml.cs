using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace OpenJam.SamplePages.NoteFinder
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NoteFinderPage : Page
    {
        public NoteFinderPage()
        {
            this.InitializeComponent();

            ViewModel = ViewModelLocator.Instance.NoteFinderInstance;
        }

        public NoteFinderViewModel ViewModel { get; set; }
    }
}
