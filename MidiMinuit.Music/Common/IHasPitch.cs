using MidiMinuit.Music.Core.Pitches;

namespace MidiMinuit.Music.Common
{
    public interface IHasPitch
    {
        Pitch Pitch { get; }
    }
}