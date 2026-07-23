# Music .NET

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
