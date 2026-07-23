![WebAudioInterop banner](.github/banner.png)

# WebAudioInterop — Web Audio API bindings for Blazor

![Build](https://img.shields.io/github/actions/workflow/status/phmatray/WebAudioInterop/dotnet.yml?branch=main)
![License](https://img.shields.io/github/license/phmatray/WebAudioInterop)

A Blazor Razor class library providing **strongly-typed C# bindings for the Web Audio API** via TypeScript/JavaScript interop. Build rich audio applications in Blazor without writing raw JS — access `AudioContext`, audio nodes, media sources, and streams through a clean .NET API.

## ✨ Features

- **AudioContext**: Full C# wrapper with `CreateAudioContextAsync()` and lifecycle management
- **BaseAudioContext**: Shared functionality including latency, sample rate, and state
- **AudioNode**: Base class for all audio processing nodes
- **Media sources**: `MediaElementAudioSourceNode`, `MediaStreamAudioSourceNode`, `MediaStreamTrackAudioSourceNode`
- **Media destinations**: `MediaStreamAudioDestinationNode`
- **State management**: `AudioContextState` enum (suspended/running/closed)
- **TypeScript source**: Interop layer written in TypeScript for type safety (`audioContextInterop.ts`)
- **Async & disposable**: All contexts implement `IAsyncDisposable` for proper cleanup
- **EventTarget base**: Foundation for audio events (state change, sink change)

## 📦 Installation

```bash
dotnet add package WebAudioInterop
```

## 🚀 Quick Start

```csharp
@inject IJSInProcessRuntime JS

// Create audio context
var audioContext = new AudioContext(JS);
await audioContext.CreateAudioContextAsync();

// Access properties
var sampleRate = audioContext.SampleRate;
var latency = audioContext.BaseLatency;

// Dispose when done
await audioContext.DisposeAsync();
```

## 🏗 Project Structure

```
WebAudioInterop/
  WebAudio/
    AudioContext.cs                        # Main audio context
    BaseAudioContext.cs                    # Shared context base
    AudioNode.cs                           # Base audio node
    AudioContextState.cs                   # State enum
    MediaElementAudioSourceNode.cs         # Media element source
    MediaStreamAudioSourceNode.cs          # Media stream source
    MediaStreamAudioDestinationNode.cs     # Stream destination
    EventTarget.cs                         # Event base class
  wwwroot/
    audioContextInterop.ts                 # TypeScript interop source
    audioContextInterop.js                 # Compiled JS
UnitTests/                                 # Test project
```

## 📄 License

MIT — see [LICENSE](LICENSE)

---

<!-- portfolio-sections:start -->

## Contributing

Contributions are welcome. Open an issue first to discuss any significant change.

1. Fork the repository and create your branch (`git checkout -b feat/my-feature`)
2. Commit your changes (`git commit -m 'feat: ...'`)
3. Push the branch and open a Pull Request

<!-- portfolio-sections:end -->
