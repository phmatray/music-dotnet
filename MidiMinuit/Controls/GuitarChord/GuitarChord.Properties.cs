using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace MidiMinuit.Controls
{
    public partial class GuitarChord
    {
        /// <summary>
        /// Defines the <see cref="FontBrush"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty FontBrushProperty = DependencyProperty.Register(
            nameof(FontBrush),
            typeof(Brush),
            typeof(GuitarChord),
            new PropertyMetadata(default(Brush)));

        /// <summary>
        /// Gets or sets the font brush.
        /// </summary>
        public Brush FontBrush
        {
            get { return (Brush)GetValue(FontBrushProperty); }
            set { SetValue(FontBrushProperty, value); }
        }
    }
}