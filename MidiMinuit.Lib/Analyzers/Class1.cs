namespace MidiMinuit.Lib.Analyzers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Windows.Media.Audio;
    using Windows.Media.Render;
    using Windows.Storage;

    internal class Class1
    {
        private AudioGraph graph;
        private AudioDeviceOutputNode deviceOutput;
        private Dictionary<string, AudioFileInputNode> fileInputs = new Dictionary<string, AudioFileInputNode>();

        public Class1()
        {


            //graph = AudioGraph.CreateAsync(new AudioGraphSettings(AudioRenderCategory.Communications))
        }
    }
}
