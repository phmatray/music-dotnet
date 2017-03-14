namespace MidiMinuit.Common
{
    using System;
    using Windows.UI;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Media;

    public static class Constants
    {
        public static readonly Color ApplicationBackgroundColor = Color.FromArgb(255, 51, 51, 51);

        public static readonly Uri Square44x44Logo = new Uri("ms-appx:///Assets/Square44x44Logo.png");
        public static readonly Uri Square150x150Logo = new Uri("ms-appx:///Assets/Square150x150Logo.png");
        public static readonly Uri Wide310x150Logo = new Uri("ms-appx:///Assets/Wide310x150Logo.png");
        public static readonly Uri Square310x310Logo = new Uri("ms-appx:///Assets/Square310x310Logo.png");

        public static string ApplicationDisplayName { get; set; }

        public static class ThemeResources
        {
            public static Brush SystemControlHighlightAccentBrush
                => Application.Current.Resources["SystemControlHighlightAccentBrush"] as SolidColorBrush;

            public static Color SystemAccentColor
                => (Color)Application.Current.Resources["SystemAccentColor"];
        }
    }
}