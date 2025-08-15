# Pomodoro

Pomodoro is a simple Windows desktop timer application based on the Pomodoro Technique, built with C# and WinForms (.NET 9).

## Description

The Pomodoro Technique helps improve productivity by alternating focused work sessions with short breaks. This application allows you to start, pause, and reset a timer, automatically switching between work and rest modes.

- **Work interval:** 25 minutes
- **Rest interval:** 5 minutes
- Automatic mode switching
- Notifications when intervals end

## Installation

1. Make sure you have [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed.
2. Clone the repository:
```
git clone https://github.com/cry4alone/PomodoroTimer
```
3. Open the project in Visual Studio 2022 or later.
4. Build and run the project (__Build > Build Solution__, then __Debug > Start Debugging__).

## Usage

- **Start:** Click the "Start" button to begin the timer.
- **Pause:** Click "Pause" to stop the timer.
- **Reset:** Click "Reset" to restart the timer and change it to the work mode.
- When an interval ends, a notification will appear and the timer will automatically switch to the next mode.

## Project Structure

- `Program.cs` — Application entry point
- `MainWindow.cs` — Main UI and event handling
- `Services/TimerService.cs` — Pomodoro timer business logic
- `Enums/TimerModes.cs` — Timer mode enumeration

## Requirements

- Windows 10/11
- .NET 9
- Visual Studio 2022 or newer
