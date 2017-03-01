using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace MidiMinuit.Controls
{
    //// All calculations are for a 200x200 square. The viewbox will do the rest.
    [TemplatePart(Name = ContainerPartName, Type = typeof(Grid))]
    public partial class GuitarChord : ContentControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuitarChord"/> class.
        /// </summary>
        public GuitarChord()
        {
            DefaultStyleKey = typeof(GuitarChord);

            FontFamily = new FontFamily("Segoe UI");
            FontSize = 12;
        }

        // Template Parts.
        private const string ContainerPartName = "PART_Container";

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            //Update();
        }

        //private void Update()
        //{
        //    //VisualStateManager.GoToState(this, "", false);
        //}
    }
}