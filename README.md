![ChordEngine banner](.github/banner.png)

# ChordEngine — Music Chord Engine in .NET

<!-- portfolio-badges:start -->
<!-- Identity -->
[![phmatray - ChordEngine](https://img.shields.io/static/v1?label=phmatray&message=ChordEngine&color=blue&logo=github)](https://github.com/phmatray/ChordEngine)
![Top language](https://img.shields.io/github/languages/top/phmatray/ChordEngine)
[![Stars](https://img.shields.io/github/stars/phmatray/ChordEngine?style=social)](https://github.com/phmatray/ChordEngine/stargazers)
[![Forks](https://img.shields.io/github/forks/phmatray/ChordEngine?style=social)](https://github.com/phmatray/ChordEngine/network/members)

<!-- Activity -->
[![Issues](https://img.shields.io/github/issues/phmatray/ChordEngine)](https://github.com/phmatray/ChordEngine/issues)
[![Pull requests](https://img.shields.io/github/issues-pr/phmatray/ChordEngine)](https://github.com/phmatray/ChordEngine/pulls)
[![Last commit](https://img.shields.io/github/last-commit/phmatray/ChordEngine)](https://github.com/phmatray/ChordEngine/commits)
<!-- portfolio-badges:end -->

<!-- portfolio-toc:start -->

## Table of Contents

- [✨ Features](#-features)
- [📦 Installation](#-installation)
- [🚀 Quick Start](#-quick-start)
- [Tech Stack](#tech-stack)
- [📄 License](#-license)
- [Contributing](#contributing)

<!-- portfolio-toc:end -->



A .NET library for music chord generation, analysis, and visualization. Includes a Blazor demo app for interactive chord exploration.

## ✨ Features
- Chord generation (major, minor, 7th, diminished, etc.)
- Chord progression analysis
- Music theory helpers (intervals, scales)
- Blazor interactive demo app
- Full unit test coverage

## 📦 Installation
```bash
dotnet add package ChordEngine
```

## 🚀 Quick Start
```csharp
var chord = Chord.Create(Note.C, ChordType.Major);
Console.WriteLine(chord.Notes); // C, E, G
var progression = Progression.Create(Key.CMajor, "I IV V I");
```

<!-- portfolio-techstack:start -->

## Tech Stack

- **.NET 7**
- Microsoft.AspNetCore.Components.WebAssembly
- Microsoft.AspNetCore.Components.WebAssembly.DevServer
- Shouldly
- xunit
- xunit.runner.visualstudio

<!-- portfolio-techstack:end -->

## 📄 License
MIT — see LICENSE

---

<!-- portfolio-sections:start -->

## Contributing

Contributions are welcome. Open an issue first to discuss any significant change.

1. Fork the repository and create your branch (`git checkout -b feat/my-feature`)
2. Commit your changes (`git commit -m 'feat: ...'`)
3. Push the branch and open a Pull Request

<!-- portfolio-sections:end -->
