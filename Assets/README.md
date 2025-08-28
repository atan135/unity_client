# Unity Project Folder Structure

This document describes the organization of assets in this Unity project following industry best practices.

## 📁 Main Asset Categories

### 🎮 **Scripts/**
Core game logic and functionality
- **Core/** - Core systems, managers, and base classes
- **Gameplay/** - Game-specific mechanics, player controls, AI
- **UI/** - User interface related scripts
- **Utils/** - Utility functions and helper classes
- **Managers/** - Game state, audio, input managers
- **Interfaces/** - Interface definitions and contracts

### 🎯 **Prefabs/**
Reusable game objects
- **UI/** - User interface prefabs (buttons, panels, etc.)
- **Gameplay/** - Game mechanics prefabs (weapons, items, etc.)
- **Environment/** - Environmental objects and structures

### 🎨 **Materials/**
Material assets for rendering
- **Standard/** - Standard Unity materials
- **Custom/** - Custom shader materials
- **Terrain/** - Terrain-specific materials

### 🖼️ **Textures/**
2D image assets
- **Characters/** - Character textures and sprites
- **Environment/** - Environmental textures
- **UI/** - User interface textures
- **Effects/** - Special effect textures

### 🏗️ **Models/**
3D model assets
- **Characters/** - Character models and meshes
- **Environment/** - Environmental models
- **Props/** - Interactive and decorative objects
- **Vehicles/** - Vehicle models

### 🔊 **Audio/**
Sound assets
- **Music/** - Background music and themes
- **SFX/** - Sound effects
- **Voice/** - Voice acting and dialogue
- **Ambient/** - Ambient environmental sounds

### 🎭 **Animations/**
Animation clips and controllers
- **Characters/** - Character animations
- **UI/** - User interface animations
- **Props/** - Object animations

### 🖥️ **UI/**
User interface assets
- **Sprites/** - UI sprites and images
- **Fonts/** - Custom fonts
- **Icons/** - UI icons and symbols

### 🔧 **Editor/**
Unity editor extensions
- **Scripts/** - Custom editor scripts
- **Windows/** - Custom editor windows

### 📦 **Plugins/**
Third-party plugins and integrations

### 📚 **lib/**
Reusable code libraries and plugins
- **Plugins/** - Third-party plugins and integrations
- **Custom/** - Your own custom code libraries (Math, Collections, Networking, AI)
- **ThirdParty/** - Modified third-party code

### 📚 **Resources/**
Runtime-loaded assets (use sparingly)

### 📡 **StreamingAssets/**
Platform-specific assets loaded at runtime

### ✨ **Shaders/**
Custom shader files

### 🌍 **Terrain/**
Terrain data and assets

### 💡 **Lighting/**
Lighting settings and lightmaps

### 🎆 **Particles/**
Particle system assets

### 🎬 **VFX/**
Visual effects assets

### 🎥 **Cinematics/**
Cutscene and cinematic assets

### 🌐 **Localization/**
Multi-language support
- **Languages/** - Language files
- **Fonts/** - Language-specific fonts

### 📊 **Data/**
Game data and configuration
- **ScriptableObjects/** - Unity ScriptableObject assets
- **JSON/** - JSON configuration files
- **XML/** - XML configuration files

### 📖 **Documentation/**
Project documentation and guides

## 📋 Best Practices

1. **Keep it organized** - Place assets in their appropriate folders
2. **Use subfolders** - Break down large categories into smaller, logical groups
3. **Consistent naming** - Use clear, descriptive names for folders and files
4. **Avoid deep nesting** - Don't go more than 3-4 levels deep
5. **Document changes** - Update this README when adding new categories

## 🔄 Maintenance

- Review folder structure monthly
- Consolidate similar categories if needed
- Remove empty folders
- Update this documentation when making changes

---
*Last updated: August 28, 2025*
