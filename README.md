# Dodgy Maze

A 3D obstacle-avoidance game built in Unity, developed as part of the **Internship in Game Development, Augmented Reality and Virtual Reality**, School of Information Science (UG), Presidency University, Bengaluru.

Guide the player through a futuristic maze filled with rotating and moving obstacles, collect coins, and reach the finish point in the shortest time possible — without colliding with a hazard.

## Gameplay

- Navigate the maze avoiding moving and rotating obstacles.
- Collect coins along the way to increase your score.
- Colliding with an obstacle ends the run (game over).
- Reach the finish point as quickly as possible.

## Built with

- **Unity 6.3 LTS (6000.3.17f1)**
- C#
- Unity Input System
- TextMesh Pro
- Unity Physics Engine

## Features

- 3D maze environment
- Smooth player controls
- Moving and rotating obstacles
- Coin collection system
- Score counter and timer
- Main menu (Play, Settings, How to Play, Achievements, Exit)
- Settings menu (music volume, sound effects, player preferences)
- Achievement panel
- Background music and button click sound effects
- Game-over system

## Script overview

| Script | Role |
|---|---|
| `MainMenuManager.cs` | Handles main menu navigation — Play, Settings, Achievements, How to Play, Exit |
| `SettingsManager.cs` | Controls music volume, sound effects, and player preferences |
| `UIButtonSound.cs` | Plays button click sound effects |
| `PlayerMovement.cs` | Handles player movement and input |
| `Spinner.cs` | Controls rotating obstacles |
| `Scorer.cs` | Handles score calculation |
| `ObjectHit.cs` | Detects collisions and triggers game-over conditions |

## Running the project

1. Install **Unity Hub** and **Unity 6.3 LTS (6000.3.17f1)**.
2. Clone this repository.
3. Open the project folder in Unity Hub → **Add** → select the cloned folder.
4. Open the main scene from `Assets/Scenes`.
5. Press **Play** in the Unity Editor.

## Development process

The project went through planning and design (game concept, UI layout, main menu, obstacle movement, scoring system), implementation (player movement, obstacle movement, coin collection, timer, score system, menus, achievement panel, audio, scene management), and testing/debugging (movement, collisions, coin collection, UI buttons, audio, scene loading, performance).

## Challenges faced

- Designing smooth player controls
- Implementing obstacle movement
- Managing scene transitions
- Creating responsive UI
- Handling collision detection
- Fixing button interactions
- Integrating audio settings

## References

- [Unity Documentation](https://docs.unity3d.com)
- [Microsoft C# Documentation](https://learn.microsoft.com/dotnet/csharp/)
- [TextMesh Pro Documentation](https://docs.unity3d.com/Packages/com.unity.textmeshpro)
- [Unity Learn](https://learn.unity.com)

## Author

**Balgovind Rana** — B.Tech Computer Science & Engineering, Presidency University (Roll No: 20241CBD0007)
Course Instructor: Dr. Vetrimani Elangovan, Assistant Professor & Head, School of Information Science (UG)
