![music-dotnet banner](.github/banner.png)

# Music .NET

<!-- portfolio-badges:start -->
<!-- Identity -->
[![phmatray - music-dotnet](https://img.shields.io/static/v1?label=phmatray&message=music-dotnet&color=blue&logo=github)](https://github.com/phmatray/music-dotnet)
![Top language](https://img.shields.io/github/languages/top/phmatray/music-dotnet)
[![Stars](https://img.shields.io/github/stars/phmatray/music-dotnet?style=social)](https://github.com/phmatray/music-dotnet/stargazers)
[![Forks](https://img.shields.io/github/forks/phmatray/music-dotnet?style=social)](https://github.com/phmatray/music-dotnet/network/members)
[![License](https://img.shields.io/github/license/phmatray/music-dotnet)](https://github.com/phmatray/music-dotnet/blob/HEAD/LICENSE)

<!-- Activity -->
[![Issues](https://img.shields.io/github/issues/phmatray/music-dotnet)](https://github.com/phmatray/music-dotnet/issues)
[![Pull requests](https://img.shields.io/github/issues-pr/phmatray/music-dotnet)](https://github.com/phmatray/music-dotnet/pulls)
[![Last commit](https://img.shields.io/github/last-commit/phmatray/music-dotnet)](https://github.com/phmatray/music-dotnet/commits)
<!-- portfolio-badges:end -->


> **Music and audio for .NET** — a theory library, a chord engine, MIDI tooling,
> Web Audio bindings, and a VGM player, consolidated in one place (full git history preserved).

## Projects

| Path | What it is | From |
|---|---|---|
| [`theory/`](theory) | **Music-theory library** — immutable models for notes, intervals, scales, chords & progressions; frequency, MIDI, enharmonic equivalence, fluent APIs | `phmatray/MusicTheory` ★ |
| [`chord-engine/`](chord-engine) | **Chord generation, analysis & Blazor visualization** | `phmatray/ChordEngine` |
| [`midi/`](midi) | **MIDI processing** toolkit with OpenJam integration | `phmatray/midiminuit` |
| [`webaudio-interop/`](webaudio-interop) | **Web Audio API** bindings for Blazor (C# ⇄ TS/JS interop) | `phmatray/WebAudioInterop` |
| [`vgm/`](vgm) | **Video Game Music** management & playback web app | `phmatray/vgm` |

## Features

- **A music-theory core** (`theory/`) the other projects can build on
- **Complementary pieces** — chords, MIDI, Web Audio, and a player — not overlapping rewrites
- **One home** — shared issues, discussions and history for all .NET music/audio work

## Usage

```bash
git clone https://github.com/phmatray/music-dotnet.git
cd music-dotnet/theory   # or chord-engine / midi / webaudio-interop / vgm
dotnet build
```

## History

Each folder was merged with **full git history preserved** (`git subtree`). The
original repositories are archived and redirect here.

## License

MIT — see [`LICENSE`](LICENSE).
