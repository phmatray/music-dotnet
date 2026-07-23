using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace OpenJam.Controls
{
    //// All calculations are for a 200x200 square. The viewbox will do the rest.
    [TemplatePart(Name = ContainerPartName, Type = typeof(Grid))]
    public partial class GuitarChord : ContentControl
    {
        // For convenience.
        private Compositor _compositor;
        private ContainerVisual _root;

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
            // Update();
        }

        private static void OnTuningChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OnTuningChanged(d);
        }

        private static void OnTuningChanged(DependencyObject d)
        {
            GuitarChord guitarChord = (GuitarChord)d;

            guitarChord.TuningNote1 = guitarChord.Tuning?.Notes[0].ToString();
            guitarChord.TuningNote2 = guitarChord.Tuning?.Notes[1].ToString();
            guitarChord.TuningNote3 = guitarChord.Tuning?.Notes[2].ToString();
            guitarChord.TuningNote4 = guitarChord.Tuning?.Notes[3].ToString();
            guitarChord.TuningNote5 = guitarChord.Tuning?.Notes[4].ToString();
            guitarChord.TuningNote6 = guitarChord.Tuning?.Notes[5].ToString();

            // GuitarChord guitarChord = (GuitarChord)d;

            // var container = guitarChord.GetTemplateChild(ContainerPartName) as Grid;
            // if (container == null || DesignMode.DesignModeEnabled)
            // {
            //    // Bad template.
            //    return;
            // }

            // guitarChord._root = container.GetVisual();
            // //guitarChord._root.Children.RemoveAll();
            // guitarChord._compositor = guitarChord._root.Compositor;

            // // Tuning.
            // var control = guitarChord._root.Children.FirstOrDefault();
            // //guitarChord._root.Children.FirstOrDefault(x => x.Name = "TextTuningCord1").Text = _compositor.Cre

            // //guitarChord.TextTuningCord1.Text = "Z";
            // //throw new NotImplementedException();
        }

        private static void OnInteractivityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GuitarChord guitarChord = (GuitarChord)d;

            if (guitarChord.IsInteractive)
            {
                guitarChord.Tapped += GuitarChord_Tapped;
            }
            else
            {
                guitarChord.Tapped -= GuitarChord_Tapped;
            }
        }

        private static void GuitarChord_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        //private void Update()
        //{
        //    //VisualStateManager.GoToState(this, "", false);
        //}
    }
}