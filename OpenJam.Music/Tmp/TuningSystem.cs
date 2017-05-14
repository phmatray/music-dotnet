using System.Collections.Generic;
using OpenJam.Music.Core;

namespace OpenJam.Music.Tmp
{
    public abstract class TuningSystem
    {
        ////public TuningDictionary AllIntervalRatios { get; protected set; }

        public abstract IEnumerable<double> TuneScale(Scale scale);
    }
}