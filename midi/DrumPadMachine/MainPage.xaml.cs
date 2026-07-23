using System;
using System.Threading.Tasks;
using Windows.Media.Audio;
using Windows.Media.Render;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DrumPadMachine
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private AudioGraph _graph;
        private AudioFileInputNode _fileInputNode1;
        private AudioFileInputNode _fileInputNode2;
        private AudioFileInputNode _fileInputNode3;
        private AudioFileInputNode _fileInputNode4;
        private AudioFileInputNode _fileInputNode5;
        private AudioFileInputNode _fileInputNode6;
        private AudioFileInputNode _fileInputNode7;
        private AudioFileInputNode _fileInputNode8;
        private AudioSubmixNode _submixNode;
        private AudioDeviceOutputNode _deviceOutputNode;
        private EchoEffectDefinition _echoEffect;

        private StorageFile _file1;
        private StorageFile _file2;
        private StorageFile _file3;
        private StorageFile _file4;
        private StorageFile _file5;
        private StorageFile _file6;
        private StorageFile _file7;
        private StorageFile _file8;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            await CreateAudioGraph();

            StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sounds");
            _file1 = await folder.GetFileAsync("clap-808.wav");
            _file2 = await folder.GetFileAsync("hihat-808.wav");
            _file3 = await folder.GetFileAsync("crash-808.wav");
            _file4 = await folder.GetFileAsync("kick-808.wav");
            _file5 = await folder.GetFileAsync("openhat-808.wav");
            _file6 = await folder.GetFileAsync("perc-808.wav");
            _file7 = await folder.GetFileAsync("snare-808.wav");
            _file8 = await folder.GetFileAsync("tom-808.wav");
        }

        private async void Button1_Click(object sender, TappedRoutedEventArgs e)
        {
            var fileInputNodeResult = await _graph.CreateFileInputNodeAsync(_file1);
            if (fileInputNodeResult.Status != AudioFileNodeCreationStatus.Success)
            {
                // Cannot read input file
                throw new Exception($"Can't read input file1 because {fileInputNodeResult.Status}");
            }

            _fileInputNode1 = fileInputNodeResult.FileInputNode;
            // Since we are going to play two files simultaneously, set outgoing gain to 0.5 to prevent clipping
            _fileInputNode1.AddOutgoingConnection(_submixNode, 0.5);

            _graph.Start();
        }

        private async void Button2_Click(object sender, TappedRoutedEventArgs e)
        {
            var fileInputNodeResult = await _graph.CreateFileInputNodeAsync(_file2);
            if (fileInputNodeResult.Status != AudioFileNodeCreationStatus.Success)
            {
                // Cannot read input file
                throw new Exception($"Can't read input file2 because {fileInputNodeResult.Status}");
            }

            _fileInputNode2 = fileInputNodeResult.FileInputNode;
            // Since we are going to play two files simultaneously, set outgoing gain to 0.5 to prevent clipping
            _fileInputNode2.AddOutgoingConnection(_submixNode, 0.5);

            _graph.Start();
        }

        private async void Button3_Click(object sender, TappedRoutedEventArgs e)
        {
            var fileInputNodeResult = await _graph.CreateFileInputNodeAsync(_file3);
            if (fileInputNodeResult.Status != AudioFileNodeCreationStatus.Success)
            {
                // Cannot read input file
                throw new Exception($"Can't read input file3 because {fileInputNodeResult.Status}");
            }

            _fileInputNode3 = fileInputNodeResult.FileInputNode;
            // Since we are going to play two files simultaneously, set outgoing gain to 0.5 to prevent clipping
            _fileInputNode3.AddOutgoingConnection(_submixNode, 0.5);

            _graph.Start();
        }

        private async void Button4_Click(object sender, TappedRoutedEventArgs e)
        {
            var fileInputNodeResult = await _graph.CreateFileInputNodeAsync(_file4);
            if (fileInputNodeResult.Status != AudioFileNodeCreationStatus.Success)
            {
                // Cannot read input file
                throw new Exception($"Can't read input file4 because {fileInputNodeResult.Status}");
            }

            _fileInputNode4 = fileInputNodeResult.FileInputNode;
            // Since we are going to play two files simultaneously, set outgoing gain to 0.5 to prevent clipping
            _fileInputNode4.AddOutgoingConnection(_submixNode, 0.5);

            _graph.Start();
        }

        private async void Button5_Click(object sender, TappedRoutedEventArgs e)
        {
            var fileInputNodeResult = await _graph.CreateFileInputNodeAsync(_file5);
            if (fileInputNodeResult.Status != AudioFileNodeCreationStatus.Success)
            {
                // Cannot read input file
                throw new Exception($"Can't read input file5 because {fileInputNodeResult.Status}");
            }

            _fileInputNode5 = fileInputNodeResult.FileInputNode;
            // Since we are going to play two files simultaneously, set outgoing gain to 0.5 to prevent clipping
            _fileInputNode5.AddOutgoingConnection(_submixNode, 0.5);

            _graph.Start();
        }

        private async void Button6_Click(object sender, TappedRoutedEventArgs e)
        {
            var fileInputNodeResult = await _graph.CreateFileInputNodeAsync(_file6);
            if (fileInputNodeResult.Status != AudioFileNodeCreationStatus.Success)
            {
                // Cannot read input file
                throw new Exception($"Can't read input file6 because {fileInputNodeResult.Status}");
            }

            _fileInputNode6 = fileInputNodeResult.FileInputNode;
            // Since we are going to play two files simultaneously, set outgoing gain to 0.5 to prevent clipping
            _fileInputNode6.AddOutgoingConnection(_submixNode, 0.5);

            _graph.Start();
        }

        private async void Button7_Click(object sender, TappedRoutedEventArgs e)
        {
            var fileInputNodeResult = await _graph.CreateFileInputNodeAsync(_file7);
            if (fileInputNodeResult.Status != AudioFileNodeCreationStatus.Success)
            {
                // Cannot read input file
                throw new Exception($"Can't read input file7 because {fileInputNodeResult.Status}");
            }

            _fileInputNode7 = fileInputNodeResult.FileInputNode;
            // Since we are going to play two files simultaneously, set outgoing gain to 0.5 to prevent clipping
            _fileInputNode7.AddOutgoingConnection(_submixNode, 0.5);

            _graph.Start();
        }

        private async void Button8_Click(object sender, TappedRoutedEventArgs e)
        {
            var fileInputNodeResult = await _graph.CreateFileInputNodeAsync(_file8);
            if (fileInputNodeResult.Status != AudioFileNodeCreationStatus.Success)
            {
                // Cannot read input file
                throw new Exception($"Can't read input file8 because {fileInputNodeResult.Status}");
            }

            _fileInputNode8 = fileInputNodeResult.FileInputNode;
            // Since we are going to play two files simultaneously, set outgoing gain to 0.5 to prevent clipping
            _fileInputNode8.AddOutgoingConnection(_submixNode, 0.5);

            _graph.Start();
        }

        private void EchoEffectToggle_Toggled(object sender, RoutedEventArgs e)
        {
            ////// Enable/Disable the echo effect
            ////// Also set the label for the UI
            ////if (echoEffectToggle.IsOn)
            ////{
            ////    submixNode.EnableEffectsByDefinition(echoEffect);
            ////}
            ////else
            ////{
            ////    submixNode.DisableEffectsByDefinition(echoEffect);
            ////}
        }

        private async Task CreateAudioGraph()
        {
            // Create an AudioGraph with default setting
            AudioGraphSettings settings = new AudioGraphSettings(AudioRenderCategory.Media);
            CreateAudioGraphResult result = await AudioGraph.CreateAsync(settings);

            if (result.Status != AudioGraphCreationStatus.Success)
            {
                // Can't create the graph
                ////rootPage.NotifyUser(String.Format("AudioGraph Creation Error because {0}", result.Status.ToString()), NotifyType.ErrorMessage);
                return;
            }

            _graph = result.Graph;

            // Create a device output node
            CreateAudioDeviceOutputNodeResult deviceOutputNodeResult = await _graph.CreateDeviceOutputNodeAsync();

            if (deviceOutputNodeResult.Status != AudioDeviceNodeCreationStatus.Success)
            {
                // Cannot create device output node
                ////rootPage.NotifyUser(String.Format("Audio Device Output unavailable because {0}", deviceOutputNodeResult.Status.ToString()), NotifyType.ErrorMessage);
                ////speakerContainer.Background = new SolidColorBrush(Colors.Red);
                return;
            }

            _deviceOutputNode = deviceOutputNodeResult.DeviceOutputNode;
            ////rootPage.NotifyUser("Device Output Node successfully created", NotifyType.StatusMessage);
            ////speakerContainer.Background = new SolidColorBrush(Colors.Green);

            _submixNode = _graph.CreateSubmixNode();
            ////submixNodeContainer.Background = new SolidColorBrush(Colors.Green);
            _submixNode.AddOutgoingConnection(_deviceOutputNode);

            _echoEffect = new EchoEffectDefinition(_graph);
            _echoEffect.WetDryMix = 0.7f;
            _echoEffect.Feedback = 0.5f;
            _echoEffect.Delay = 500.0f;
            _submixNode.EffectDefinitions.Add(_echoEffect);

            // Disable the effect in the beginning. Enable in response to user action (UI toggle switch)
            _submixNode.DisableEffectsByDefinition(_echoEffect);

            // All nodes can have an OutgoingGain property
            // Setting the gain on the Submix node attenuates the output of the node
            _submixNode.OutgoingGain = 0.5;

            // Graph successfully created. Enable buttons to load files
            ////fileButton1.IsEnabled = true;
            ////fileButton2.IsEnabled = true;
        }

        private void Button1_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }
    }
}
