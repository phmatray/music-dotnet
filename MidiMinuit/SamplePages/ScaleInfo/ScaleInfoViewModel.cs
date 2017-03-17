namespace MidiMinuit.SamplePages.ScaleInfo
{
    using System.Collections.ObjectModel;
    using GalaSoft.MvvmLight;
    using MidiMinuit.Lib.Core.Degrees;
    using MidiMinuit.Lib.Core.Notes;
    using MidiMinuit.Lib.Core.Scales;

    public class ScaleInfoViewModel : ViewModelBase
    {
        public ObservableCollection<Scale> Scales { get; private set; }

        public ScaleInfoViewModel()
        {
            var key = new Note(NoteNameEnum.C);
            Scales = new ObservableCollection<Scale>
            {
                new ScaleMajor(key),
                new ScaleMinorHarmonic(key),
                new ScaleMinorMelodic(key),
                new ScaleMinorNaturalEolian(key)
            };
        }
    }
}