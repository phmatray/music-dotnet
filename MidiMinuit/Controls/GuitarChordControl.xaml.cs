using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MidiMinuit.Controls
{
    public sealed partial class GuitarChordControl : UserControl
    {
        public GuitarChordControl()
        {
            this.InitializeComponent();

            this.DefaultStyleKey = typeof(GuitarChordControl);
            this.FontFamily = new FontFamily("Segoe UI");
            this.FontSize = 12;
            FontBrush = new SolidColorBrush(Colors.Brown);
            Foreground = new SolidColorBrush(Colors.Brown);
        }

        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.Register(
            "Foreground", typeof(Brush), typeof(GuitarChordControl), new PropertyMetadata(default(Brush)));

        public Brush Foreground
        {
            get { return (Brush) GetValue(ForegroundProperty); }
            set { SetValue(ForegroundProperty, value); }
        }

        public static readonly DependencyProperty FontBrushProperty = DependencyProperty.Register(
            "FontBrush", typeof(Brush), typeof(GuitarChordControl), new PropertyMetadata(default(Brush)));

        public Brush FontBrush
        {
            get { return (Brush)GetValue(FontBrushProperty); }
            set { SetValue(FontBrushProperty, value); }
        }

        public static readonly DependencyProperty MyFontFamilyProperty = DependencyProperty.Register(
            "MyFontFamily", typeof(FontFamily), typeof(GuitarChordControl), new PropertyMetadata(default(FontFamily)));

        public FontFamily MyFontFamily
        {
            get { return (FontFamily) GetValue(MyFontFamilyProperty); }
            set { SetValue(MyFontFamilyProperty, value); }
        }

        public static readonly DependencyProperty MyFontSizeProperty = DependencyProperty.Register(
            "MyFontSize", typeof(double), typeof(GuitarChordControl), new PropertyMetadata(default(double)));

        public double MyFontSize
        {
            get { return (double) GetValue(MyFontSizeProperty); }
            set { SetValue(MyFontSizeProperty, value); }
        }

        public static readonly DependencyProperty MyWidthProperty = DependencyProperty.Register(
            "MyWidth", typeof(double), typeof(GuitarChordControl), new PropertyMetadata(default(double)));

        public double MyWidth
        {
            get { return (double) GetValue(MyWidthProperty); }
            set { SetValue(MyWidthProperty, value); }
        }

        public static readonly DependencyProperty MyHeightProperty = DependencyProperty.Register(
            "MyHeight", typeof(double), typeof(GuitarChordControl), new PropertyMetadata(default(double)));

        public double MyHeight
        {
            get { return (double) GetValue(MyHeightProperty); }
            set { SetValue(MyHeightProperty, value); }
        }

        public static readonly DependencyProperty MyBorderThicknessProperty = DependencyProperty.Register(
            "MyBorderThickness", typeof(Thickness), typeof(GuitarChordControl), new PropertyMetadata(default(Thickness)));

        public Thickness MyBorderThickness
        {
            get { return (Thickness) GetValue(MyBorderThicknessProperty); }
            set { SetValue(MyBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty MyBorderBrushProperty = DependencyProperty.Register(
            "MyBorderBrush", typeof(Brush), typeof(GuitarChordControl), new PropertyMetadata(default(Brush)));

        public Brush MyBorderBrush
        {
            get { return (Brush) GetValue(MyBorderBrushProperty); }
            set { SetValue(MyBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty MyBackgroundProperty = DependencyProperty.Register(
            "MyBackground", typeof(Brush), typeof(GuitarChordControl), new PropertyMetadata(default(Brush)));

        public Brush MyBackground
        {
            get { return (Brush) GetValue(MyBackgroundProperty); }
            set { SetValue(MyBackgroundProperty, value); }
        }

        public static readonly DependencyProperty MyPaddingProperty = DependencyProperty.Register(
            "MyPadding", typeof(Thickness), typeof(GuitarChordControl), new PropertyMetadata(default(Thickness)));

        public Thickness MyPadding
        {
            get { return (Thickness) GetValue(MyPaddingProperty); }
            set { SetValue(MyPaddingProperty, value); }
        }
    }
}
