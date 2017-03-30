using System;
using MidiMinuit.Common;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using MidiMinuit.Music.Core.Chords;
using MidiMinuit.Music.Core.Notes;
using MidiMinuit.Music.Instruments.GuitarTunings;

namespace MidiMinuit.Controls
{
    public partial class GuitarChord
    {
        /// <summary>
        /// Identifies the <see cref="FontBrush"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty FontBrushProperty =
            DependencyProperty.Register(nameof(FontBrush), typeof(Brush), typeof(GuitarChord), new PropertyMetadata(Constants.ThemeResources.SystemControlHighlightAccentBrush));

        /// <summary>
        /// Identifies the <see cref="IsInteractive"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty IsInteractiveProperty =
            DependencyProperty.Register(nameof(IsInteractive), typeof(bool), typeof(GuitarChord), new PropertyMetadata(false));

        /// <summary>
        /// Identifies the <see cref="Tuning"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TuningProperty =
            DependencyProperty.Register(nameof(Tuning), typeof(GuitarTuning), typeof(GuitarChord), new PropertyMetadata(new GuitarTuningStandard(), OnTuningChanged));

        /// <summary>
        /// Identifies the <see cref="TuningNote1"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TuningNote1Property =
            DependencyProperty.Register(nameof(TuningNote1), typeof(string), typeof(GuitarChord), new PropertyMetadata("E"));

        /// <summary>
        /// Identifies the <see cref="TuningNote2"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TuningNote2Property =
            DependencyProperty.Register(nameof(TuningNote2), typeof(string), typeof(GuitarChord), new PropertyMetadata("A"));

        /// <summary>
        /// Identifies the <see cref="TuningNote3"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TuningNote3Property =
            DependencyProperty.Register(nameof(TuningNote3), typeof(string), typeof(GuitarChord), new PropertyMetadata("D"));

        /// <summary>
        /// Identifies the <see cref="TuningNote4"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TuningNote4Property =
            DependencyProperty.Register(nameof(TuningNote4), typeof(string), typeof(GuitarChord), new PropertyMetadata("G"));

        /// <summary>
        /// Identifies the <see cref="TuningNote5"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TuningNote5Property =
            DependencyProperty.Register(nameof(TuningNote5), typeof(string), typeof(GuitarChord), new PropertyMetadata("B"));

        /// <summary>
        /// Identifies the <see cref="TuningNote6"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty TuningNote6Property =
            DependencyProperty.Register(nameof(TuningNote6), typeof(string), typeof(GuitarChord), new PropertyMetadata("e"));

        /// <summary>
        /// Identifies the <see cref="Chord"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ChordProperty =
            DependencyProperty.Register(nameof(Chord), typeof(Chord), typeof(GuitarChord), new PropertyMetadata(new ChordMajor(new Pitch())));














        /// <summary>
        /// Gets or sets the font brush.
        /// </summary>
        public Brush FontBrush
        {
            get { return (Brush)GetValue(FontBrushProperty); }
            set { SetValue(FontBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the control accepts setting its value through interaction.
        /// </summary>
        public bool IsInteractive
        {
            get { return (bool)GetValue(IsInteractiveProperty); }
            set { SetValue(IsInteractiveProperty, value); }
        }

        /// <summary>
        /// Gets or sets the tuning used for this diagram
        /// </summary>
        public GuitarTuning Tuning
        {
            get { return (GuitarTuning)GetValue(TuningProperty); }
            set { SetValue(TuningProperty, value); }
        }

        /// <summary>
        /// Gets or sets the 1st note of the tuning used for this diagram
        /// </summary>
        public string TuningNote1
        {
            get { return (string)GetValue(TuningNote1Property); }
            private set { SetValue(TuningNote1Property, value); }
        }

        /// <summary>
        /// Gets or sets the 2nd note of the tuning used for this diagram
        /// </summary>
        public string TuningNote2
        {
            get { return (string)GetValue(TuningNote2Property); }
            private set { SetValue(TuningNote2Property, value); }
        }

        /// <summary>
        /// Gets or sets the 3rd note of the tuning used for this diagram
        /// </summary>
        public string TuningNote3
        {
            get { return (string)GetValue(TuningNote3Property); }
            private set { SetValue(TuningNote3Property, value); }
        }

        /// <summary>
        /// Gets or sets the 4th note of the tuning used for this diagram
        /// </summary>
        public string TuningNote4
        {
            get { return (string)GetValue(TuningNote4Property); }
            private set { SetValue(TuningNote4Property, value); }
        }

        /// <summary>
        /// Gets or sets the 5th note of the tuning used for this diagram
        /// </summary>
        public string TuningNote5
        {
            get { return (string)GetValue(TuningNote5Property); }
            private set { SetValue(TuningNote5Property, value); }
        }

        /// <summary>
        /// Gets or sets the 6th note of the tuning used for this diagram
        /// </summary>
        public string TuningNote6
        {
            get { return (string)GetValue(TuningNote6Property); }
            private set { SetValue(TuningNote6Property, value); }
        }

        /// <summary>
        /// Gets or sets the chord represented by this diagram
        /// </summary>
        public Chord Chord
        {
            get { return (Chord)GetValue(ChordProperty); }
            set { SetValue(ChordProperty, value); }
        }
    }
}