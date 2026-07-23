namespace WebAudioInterop.WebAudio;

/// <summary>
/// Represents the current state of an AudioContext.
/// </summary>
public enum AudioContextState
{
    /// <summary>
    /// The AudioContext has been suspended with the AudioContext.Suspend() method.
    /// </summary>
    Suspended,

    /// <summary>
    /// The AudioContext is running normally.
    /// </summary>
    Running,

    /// <summary>
    /// The AudioContext has been closed with the AudioContext.Close() method.
    /// </summary>
    Closed
}