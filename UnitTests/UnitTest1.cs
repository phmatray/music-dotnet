using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using WebAudioInterop.WebAudio;

namespace UnitTests;

public class AudioContextTests : TestContext
{
    private readonly AudioContext _audioContext;

    public AudioContextTests()
    {
        // Add the Blazor WebAssembly JS runtime service to the DI container
        Services.AddSingleton<IJSRuntime>(new TestJSRuntime());

        // Create an instance of the AudioContext class
        _audioContext = Services.GetService<AudioContext>();
    }
    
    [Fact]
    public async Task TestGetBaseLatencyAsync()
    {
        // Arrange
        var expectedBaseLatency = 0.01;

        // Act
        var actualBaseLatency = await _audioContext.GetBaseLatencyAsync();

        // Assert
        Assert.Equal(expectedBaseLatency, actualBaseLatency);
    }

    [Fact]
    public async Task TestGetOutputLatencyAsync()
    {
        // Arrange
        var expectedOutputLatency = 0.02;

        // Act
        var actualOutputLatency = await _audioContext.GetOutputLatencyAsync();

        // Assert
        Assert.Equal(expectedOutputLatency, actualOutputLatency);
    }

    [Fact]
    public async Task TestGetSinkIdAsync()
    {
        // Arrange
        var expectedSinkId = "default";

        // Act
        var actualSinkId = await _audioContext.GetSinkIdAsync();

        // Assert
        Assert.Equal(expectedSinkId, actualSinkId);
    }

    [Fact]
    public async Task TestCreateMediaElementSourceAsync()
    {
        // Arrange
        var mediaElementRef = new TestJSObjectReference();

        // Act
        var mediaElementAudioSourceNode = await _audioContext.CreateMediaElementSourceAsync(mediaElementRef);

        // Assert
        Assert.NotNull(mediaElementAudioSourceNode);
        Assert.IsType<MediaElementAudioSourceNode>(mediaElementAudioSourceNode);
    }

    [Fact]
    public async Task TestCreateMediaStreamSourceAsync()
    {
        // Arrange
        var mediaStreamRef = new TestJSObjectReference();

        // Act
        var mediaStreamAudioSourceNode = await _audioContext.CreateMediaStreamSourceAsync(mediaStreamRef);

        // Assert
        Assert.NotNull(mediaStreamAudioSourceNode);
        Assert.IsType<MediaStreamAudioSourceNode>(mediaStreamAudioSourceNode);
    }

    [Fact]
    public async Task TestCreateMediaStreamDestinationAsync()
    {
        // Act
        var mediaStreamAudioDestinationNode = await _audioContext.CreateMediaStreamDestinationAsync();

        // Assert
        Assert.NotNull(mediaStreamAudioDestinationNode);
        Assert.IsType<MediaStreamAudioDestinationNode>(mediaStreamAudioDestinationNode);
    }

    [Fact]
    public async Task TestCreateMediaStreamTrackSourceAsync()
    {
        // Arrange
        var mediaStreamTrackRef = new TestJSObjectReference();

        // Act
        var mediaStreamTrackAudioSourceNode = await _audioContext.CreateMediaStreamTrackSourceAsync(mediaStreamTrackRef);

        // Assert
        Assert.NotNull(mediaStreamTrackAudioSourceNode);
        Assert.IsType<MediaStreamTrackAudioSourceNode>(mediaStreamTrackAudioSourceNode);
    }

    [Fact]
    public async Task TestGetOutputTimestampAsync()
    {
        // Act
        var audioTimestamp = await _audioContext.GetOutputTimestampAsync();

        // Assert
        Assert.NotNull(audioTimestamp);
        Assert.IsType<AudioTimestamp>(audioTimestamp);
    }

    [Fact]
    public async Task TestResumeAsync()
    {
        // Act
        await _audioContext.ResumeAsync();
    }
    
    [Fact]
    public async Task TestSetSinkIdAsync()
    {
        // Arrange
        var deviceId = "default";

        // Act
        await _audioContext.SetSinkIdAsync(deviceId);
    }

    [Fact]
    public async Task TestSuspendAsync()
    {
        // Act
        await _audioContext.SuspendAsync();
    }
    
    [Fact]
    public void TestSinkChangedEvent()
    {
        // Arrange
        var eventRaised = false;

        // Act
        _audioContext.SinkChanged += (sender, args) =>
        {
            eventRaised = true;
        };

        ((IJSObjectReference)_audioContext).InvokeVoidAsync("sinkchange");

        // Assert
        Assert.True(eventRaised);
    }
}