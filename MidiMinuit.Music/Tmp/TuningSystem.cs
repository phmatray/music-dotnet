using System.Collections.Generic;
using MidiMinuit.Music.Core.Scales;

namespace MidiMinuit.Music.Core.Tuning
{
    public abstract class TuningSystem
    {
        ////public TuningDictionary AllIntervalRatios { get; protected set; }

        public abstract IEnumerable<double> TuneScale(Scale scale);
    }
}