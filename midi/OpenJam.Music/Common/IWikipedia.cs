using System;

namespace OpenJam.Music.Common
{
    public interface IWikipedia
    {
        Uri WikipediaUrl { get; }

        string WikipediaDescription { get; }
    }
}