> [!IMPORTANT]  
> This plugin requires my fork of [PKHeX](https://github.com/hexbyt3/PKHeXth/releases/) to work right.  

![GitHub Release](https://img.shields.io/github/v/release/hexbyt3/BDSPSeedFinderPlugin)
![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/hexbyt3/BDSPSeedFinderPlugin/total?color=violet)

# BDSP Seed Finder Plugin for PKHeX

A seed finder for Brilliant Diamond & Shining Pearl's roaming encounters (Mesprit and Cresselia). These are the only BDSP encounters with a verifiable seed correlation, and since the seed space is only 32 bits, you can search the entire range in minutes.

**Author:** [@hexbyt3](https://github.com/hexbyt3)

## About

In BDSP, roaming encounters use the Pokemon's Encryption Constant as a 32-bit seed. That single value determines everything — PID, IVs, ability, height, and weight — through the Xoroshiro128Plus8b RNG. This plugin searches that seed space to find encounters matching your criteria.

Other BDSP encounters (static legends, wild Pokemon) use a 128-bit RNG state that can't be practically searched, so this plugin focuses on what's actually useful.

## Features

- Search the full 32-bit seed range (~4.3 billion seeds) with multi-core parallel processing
- Filter by shiny type (square, star, any), IV ranges, ability, and nature
- Full range search completes in minutes on a modern CPU
- Dark theme results grid with shiny highlighting
- Preview panel with sprite, stats, and seed details
- Double-click any result to load it directly into PKHeX
- Export results to CSV

## Requirements

- PKHeX (latest version recommended)
- Windows 10 or 11
- .NET 9.0 runtime

## Installation

1. Download the latest `BDSPSeedFinderPlugin.dll` from the [releases page](https://github.com/hexbyt3/BDSPSeedFinderPlugin/releases)
2. Place it in PKHeX's `plugins` folder (create it if it doesn't exist)
3. Restart PKHeX
4. Load a BD or SP save file
5. Open from Tools > BDSP Seed Finder (or Ctrl+Shift+B)

## Usage

1. Pick Mesprit or Cresselia
2. Set your TID/SID (auto-loaded from your save)
3. Set your search criteria — shiny type, IV ranges, ability
4. Choose a nature (applied via Synchronize in-game, so any nature is valid)
5. Click Search
6. Double-click a result to load it into the PKHeX editor

### How Nature Works

Roaming encounters in BDSP assume Synchronize is used, so nature isn't determined by the seed. Pick whatever nature you want — the plugin will set it on the generated Pokemon. The seed only controls PID, IVs, ability, and height/weight.

### Performance

The plugin uses all available CPU cores. Since the seed space is only 32 bits:

- **8-core CPU**: Full range in ~2-5 minutes
- **16-core CPU**: Full range in ~1-3 minutes

You'll usually find what you need well before a full search completes.

## Building from Source

1. Clone this repository
2. Place `PKHeX.Core.dll` in `BDSPSeedFinderPlugin/Deps/`
3. Open `BDSPSeedFinderPlugin.sln` in Visual Studio 2022+
4. Build in Release mode
5. Output is in `bin/Release/net9.0-windows/`

Optionally create a `local.props` file at the repo root to auto-deploy:
```xml
<Project>
  <PropertyGroup>
    <PKHeXPluginsPath>path\to\PKHeX\plugins</PKHeXPluginsPath>
  </PropertyGroup>
</Project>
```

## Technical Details

- Roaming seed = Encryption Constant (32-bit)
- RNG: Xoroshiro128Plus8b with SplitMix64 state expansion
- Sequence: EC → fakeTID → PID → 3 flawless IVs → 3 random IVs → ability → height → weight
- PID is revised to match the player's TID/SID shiny type
- Quick-verify runs the RNG inline without allocating a full PB8, then only generates the real object on match

## Credits

- **Kurt (@kwsch)** — PKHeX and the encounter/RNG framework this builds on
- All PKHeX contributors

## License

MIT License. See LICENSE for details.

## Disclaimer

This tool is for educational purposes. Please respect the game and other players.

---

For more information about PKHeX, visit the [official repository](https://github.com/kwsch/PKHeX).
