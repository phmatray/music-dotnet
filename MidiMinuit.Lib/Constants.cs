namespace MidiMinuit.Lib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MidiMinuit.Lib.Core.Chords;

    public static class Constants
    {
        public static List<ChordQualityEnum> EnumListChordQualities
            => Enum.GetValues(typeof(ChordQualityEnum))
                .Cast<ChordQualityEnum>()
                .ToList();
    }
}
