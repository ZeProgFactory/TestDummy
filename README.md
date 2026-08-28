<p align="center">
  <img src="Maui/Resources/AppIcon/icon.svg" alt="TestDummy icon" width="96" height="96" />
</p>

<h1 align="center">TestDummy</h1>

<p align="center">
  A .NET MAUI sample/test application used as a driver app for <strong>UITestForge</strong>.
</p>

## About

TestDummy is a lightweight .NET MAUI application built to exercise and validate UI automation
scenarios for UITestForge. It targets multiple platforms (Android, iOS, MacCatalyst, and Windows)
and provides a set of sample pages/controls that automated tests can interact with.

## Getting Started

### Prerequisites

- Visual Studio 2022/2026 with the **.NET MAUI** workload installed
- .NET 10 SDK

### Build & Run

1. Clone the repository:
   ```powershell
   git clone https://github.com/ZeProgFactory/TestDummy.git
   ```
2. Open `TestDummy.slnx` in Visual Studio.
3. Select a target platform (Android, iOS, MacCatalyst, or Windows) and press **Run**.

Alternatively, from the command line:
```powershell
dotnet build Maui/TestDummy.Maui.csproj -f net10.0-windows10.0.19041.0
```

## Project Structure

| Path | Description |
|------|--------------|
| `Maui/` | .NET MAUI project source |
| `Maui/Resources/AppIcon` | Application icon assets |
| `Maui/Resources/Images` | Sample images used across pages |
| `Maui/Platforms` | Platform-specific code (Android, iOS, MacCatalyst, Windows) |

## Contributing

Issues and pull requests are welcome. Please open an issue to discuss any significant changes
before submitting a PR.

## License

This project does not currently specify a license.
