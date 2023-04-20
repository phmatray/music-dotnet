using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace WebAudioInterop.WebAudio;

/// <summary>
/// Represents an audio-processing graph built from audio modules linked together, each represented by an AudioNode.
/// </summary>
public class AudioContext : BaseAudioContext, IAsyncDisposable
{
    private EventHandler? _sinkChanged;

    /// <summary>
    /// Initializes a new instance of the AudioContext class.
    /// </summary>
    /// <param name="jsRuntime">The JS runtime used for JS interop.</param>
    public AudioContext(IJSInProcessRuntime jsRuntime)
        : base(jsRuntime)
    {
    }
    
    public async Task<AudioContext> CreateAudioContextAsync()
    {
        var module = await ModuleTask.Value;
        AudioContextJS = await module.InvokeAsync<IJSObjectReference>("createAudioContext");
        return this;
    }
    
    /// <summary>
    /// Gets the number of seconds of processing latency incurred by the AudioContext passing the audio from the AudioDestinationNode to the audio subsystem.
    /// </summary>
    /// <returns>A double representing the base latency.</returns>
    public async ValueTask<double> GetBaseLatencyAsync()
    {
        var module = await ModuleTask.Value;
        return await module.InvokeAsync<double>(
            "getBaseLatency",
            new object?[] { AudioContextJS });
    }

    /// <summary>
    /// Gets an estimation of the output latency of the current audio context.
    /// </summary>
    /// <returns>A double representing the output latency.</returns>
    public async ValueTask<double> GetOutputLatencyAsync()
    {
        var module = await ModuleTask.Value;
        return await module.InvokeAsync<double>(
            "getProperty",
            new object?[] { AudioContextJS, "outputLatency" });
    }

    /// <summary>
    /// Gets the sink ID of the current output audio device.
    /// </summary>
    /// <returns>A string representing the sink ID.</returns>
    public async ValueTask<string> GetSinkIdAsync()
    {
        var module = await ModuleTask.Value;
        return await module.InvokeAsync<string>(
            "getProperty",
            new object?[] { AudioContextJS, "sinkId" });
    }

    /// <summary>
    /// Closes the audio context, releasing any system audio resources that it uses.
    /// </summary>
    /// <returns>A task that represents the asynchronous close operation.</returns>
    public async ValueTask CloseAsync()
    {
        var module = await ModuleTask.Value;
        await module.InvokeVoidAsync("closeAudioContext", AudioContextJS);
    }

    /// <summary>
    /// Creates a MediaElementAudioSourceNode associated with an HTMLMediaElement. This can be used to play and manipulate audio from <video> or <audio> elements.
    /// </summary>
    /// <param name="mediaElement">The HTMLMediaElement to associate with the new MediaElementAudioSourceNode.</param>
    /// <returns>A new MediaElementAudioSourceNode instance.</returns>
    public async ValueTask<MediaElementAudioSourceNode> CreateMediaElementSourceAsync(ElementReference mediaElement)
    {
        if (AudioContextJS is null)
            throw new InvalidOperationException("AudioContextJS is null. Call CreateAudioContextAsync first.");
        
        var mediaElementAudioSourceNode =
            await AudioContextJS.InvokeAsync<IJSObjectReference>("createMediaElementSource", mediaElement);
        
        return new MediaElementAudioSourceNode(mediaElementAudioSourceNode);
    }
    
    // /// <summary>
    // /// Creates a MediaStreamAudioSourceNode associated with a MediaStream representing an audio stream which may come from the local computer microphone or other sources.
    // /// </summary>
    // /// <param name="mediaStream">The MediaStream to associate with the new MediaStreamAudioSourceNode.</param>
    // /// <returns>A new MediaStreamAudioSourceNode instance.</returns>
    // public async ValueTask<MediaStreamAudioSourceNode> CreateMediaStreamSourceAsync(IJSObjectReference mediaStream)
    // {
    //     var mediaStreamAudioSourceNode =
    //         await _audioContext.InvokeAsync<IJSObjectReference>("createMediaStreamSource", mediaStream);
    //     return new MediaStreamAudioSourceNode(_jsRuntime, mediaStreamAudioSourceNode);
    // }
    //
    // /// <summary>
    // /// Creates a MediaStreamAudioDestinationNode associated with a MediaStream representing an audio stream which may be stored in a local file or sent to another computer.
    // /// </summary>
    // /// <returns>A new MediaStreamAudioDestinationNode instance.</returns>
    // public async ValueTask<MediaStreamAudioDestinationNode> CreateMediaStreamDestinationAsync()
    // {
    //     var mediaStreamAudioDestinationNode =
    //         await _audioContext.InvokeAsync<IJSObjectReference>("createMediaStreamDestination");
    //     return new MediaStreamAudioDestinationNode(_jsRuntime, mediaStreamAudioDestinationNode);
    // }
    //
    // /// <summary>
    // /// Creates a MediaStreamTrackAudioSourceNode associated with a MediaStream representing an media stream track.
    // /// </summary>
    // /// <param name="mediaStreamTrack">The MediaStreamTrack to associate with the new MediaStreamTrackAudioSourceNode.</param>
    // /// <returns>A new MediaStreamTrackAudioSourceNode instance.</returns>
    // public async ValueTask<MediaStreamTrackAudioSourceNode> CreateMediaStreamTrackSourceAsync(
    //     IJSObjectReference mediaStreamTrack)
    // {
    //     var mediaStreamTrackAudioSourceNode =
    //         await _audioContext.InvokeAsync<IJSObjectReference>("createMediaStreamTrackSource", mediaStreamTrack);
    //     return new MediaStreamTrackAudioSourceNode(_jsRuntime, mediaStreamTrackAudioSourceNode);
    // }

    /// <summary>
    /// Returns a new AudioTimestamp object containing two audio timestamp values relating to the current audio context.
    /// </summary>
    /// <returns>A new AudioTimestamp instance.</returns>
    public async ValueTask<AudioTimestamp> GetOutputTimestampAsync()
    {
        var audioTimestamp = await AudioContextJS.InvokeAsync<IJSObjectReference>("getOutputTimestamp");
        return new AudioTimestamp(audioTimestamp);
    }

    /// <summary>
    /// Resumes the progression of time in an audio context that has previously been suspended/paused.
    /// </summary>
    /// <returns>A task that represents the asynchronous resume operation.</returns>
    public async ValueTask ResumeAsync() =>
        await AudioContextJS.InvokeVoidAsync("resume");

    /// <summary>
    /// Sets the output audio device for the AudioContext.
    /// </summary>
    /// <param name="deviceId">The ID of the output audio device to set.</param>
    /// <returns>A task that represents the asynchronous setSinkId operation.</returns>
    public async ValueTask SetSinkIdAsync(string deviceId) =>
        await AudioContextJS.InvokeVoidAsync("setSinkId", deviceId);

    /// <summary>
    /// Suspends the progression of time in the audio context, temporarily halting audio hardware access and reducing CPU/battery usage in the process.
    /// </summary>
    /// <returns>A task that represents the asynchronous suspend operation.</returns>
    public async ValueTask SuspendAsync() =>
        await AudioContextJS.InvokeVoidAsync("suspend");

    /// <summary>
    /// Occurs when the output audio device (and therefore, the AudioContext.sinkId) has changed.
    /// </summary>
    public event EventHandler SinkChanged
    {
        add
        {
            if (_sinkChanged == null)
            {
                AudioContextJS.InvokeVoidAsync("addEventListener", "sinkchange", DotNetObjectReference.Create(this));
            }

            _sinkChanged += value;
        }
        remove
        {
            _sinkChanged -= value;

            if (_sinkChanged == null)
            {
                AudioContextJS.InvokeVoidAsync("removeEventListener", "sinkchange", DotNetObjectReference.Create(this));
            }
        }
    }

    [JSInvokable("sinkchange")]
        public async void OnSinkChanged()
    {
        _sinkChanged?.Invoke(this, EventArgs.Empty);
    }

    public async ValueTask DisposeAsync()
    {
        if (ModuleTask.IsValueCreated)
        {
            var module = await ModuleTask.Value;
            await module.DisposeAsync();
        }
    }
}