using System;
using System.Collections.Generic;
using System.Linq;

namespace MidiMinuit.Music.Core.Pitches
{
    public partial class Pitch
    {
        public static List<Pitch> CreateAll()
        {
            return Enum.GetValues(typeof(PitchAlias))
                .Cast<PitchAlias>()
                .Select(Create)
                .ToList();
        }

        public static Pitch Create(PitchAlias alias)
        {
            throw new NotImplementedException();
        }
    }
}