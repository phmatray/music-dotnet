using System.Collections.Generic;

namespace MidiMinuit.Music.Core.Tuning
{
    public abstract class TuningSystem
    {
        ////public TuningDictionary AllIntervalRatios { get; protected set; }

        public abstract IEnumerable<double> TuneScale(Scale scale);
    }
}