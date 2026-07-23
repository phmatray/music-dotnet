using Microsoft.JSInterop;

namespace WebAudioInterop.WebAudio;

public class MediaElementAudioSourceNode : AudioNode
{
    private readonly IJSObjectReference _mediaElementAudioSourceNode;

    public MediaElementAudioSourceNode(IJSObjectReference mediaElementAudioSourceNode)
    {
        _mediaElementAudioSourceNode = mediaElementAudioSourceNode;
    }
}