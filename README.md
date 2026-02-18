# ChordEngine — Music Chord Engine in .NET

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

## 📄 License
MIT — see LICENSE
