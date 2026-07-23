using System.Linq;

namespace OpenJam.Music.Core
{
    public static class ChordExtensions
    {
        public static bool IsInScale(this Chord chord, Scale scale)
            => chord.Steps.All(x => scale.Steps.Contains(x));
    }
}