# ActionRPG UE5.5

A port of Epic's ActionRPG sample project to Unreal Engine 5.5. This project demonstrates gameplay mechanics commonly found in action RPG games, updated to leverage UE5's features.

## Overview

ActionRPG is a sample project that showcases:
- Gameplay Ability System integration
- Inventory and item system
- Character abilities and attributes
- Basic AI behaviors
- Action RPG combat mechanics

## Requirements

- Unreal Engine 5.5 or later
- Visual Studio 2022 or later
- Windows 10/11 SDK

## Getting Started

1. Clone the repository into your projects "Plugins" folder
2. Copy the contents from Config.zip to your Projects "Config" folder (or you'll get a crash)
3. Right-click the .uproject file and select "Generate Visual Studio project files"
4. Open the solution and build
5. Launch the project in Unreal Engine
6. In Project settings under "Maps & Modes" set GameInstance to BP_GameInstance
7. In your maps world settings, set GameMode to BP_GameMode, and Pawn to BP_PlayerCharacter

## Key Features

- Complete Gameplay Ability System (GAS) implementation
- Inventory system with different item types
- Character attributes and status effects
- Basic melee combat system
- Example character abilities
- AI enemy behaviors

## Project Structure

- `/Source` - C++ source code
- `/Content/ActionRPG` - All project assets

## Contributing

Feel free to submit issues and pull requests.

## License

This project is licensed under the same terms as the original ActionRPG sample from Epic Games.

## Credits

- Original ActionRPG sample by Epic Games
- UE5.5 port by [Martin Dahlgren]

## Version History

See [CHANGELOG.md](CHANGELOG.md) for version history.