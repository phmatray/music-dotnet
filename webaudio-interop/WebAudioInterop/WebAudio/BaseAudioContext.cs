using Microsoft.JSInterop;

namespace WebAudioInterop.WebAudio;

public abstract class BaseAudioContext : EventTarget, IAsyncDisposable
{
    protected Lazy<Task<IJSObjectReference>> ModuleTask { get; }
    protected IJSObjectReference? AudioContextJS { get; set; }

    /// <summary>
    /// Initializes a new instance of the BaseAudioContext class.
    /// </summary>
    /// <param name="jsRuntime">The JS runtime used for JS interop.</param>
    protected BaseAudioContext(IJSRuntime jsRuntime)
    {
        ModuleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/WebAudioInterop/audioContextInterop.js").AsTask());
    }

    /// <summary>
    /// Gets the current state of the AudioContext.
    /// </summary>
    /// <returns>A string representing the state.</returns>
    public async ValueTask<AudioContextState> GetStateAsync()
    {
        // FROM THE BASE CLASS (BaseAudioContext.cs):
        var module = await ModuleTask.Value;
        
        var state = await module.InvokeAsync<string>(
            "getProperty",
            new object?[] { AudioContextJS, "state" });
        
        return state switch
        {
            "suspended" => AudioContextState.Suspended,
            "running" => AudioContextState.Running,
            "closed" => AudioContextState.Closed,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public async ValueTask<double> GetCurrentTimeAsync()
    {
        var module = await ModuleTask.Value;
        return await module.InvokeAsync<double>(
            "getProperty",
            new object?[] { AudioContextJS, "currentTime" });
    }
    
    public async ValueTask<float> GetSampleRateAsync()
    {
        var module = await ModuleTask.Value;
        return await module.InvokeAsync<float>(
            "getProperty",
            new object?[] { AudioContextJS, "sampleRate" });
    }

    public ValueTask DisposeAsync()
    {
        throw new NotImplementedException();
    }
}