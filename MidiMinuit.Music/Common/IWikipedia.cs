using System;

namespace MidiMinuit.Music.Common
{
    public interface IWikipedia
    {
        Uri WikipediaUrl { get; }

        string WikipediaDescription { get; }
    }
}