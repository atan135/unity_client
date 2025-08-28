# Library Code Organization

This folder contains reusable code libraries, plugins, and custom implementations for the Unity project.

## 📁 Folder Structure

### 🔌 **Plugins/**
Third-party plugins and integrations that extend Unity functionality.
- Place DLL files, native plugins, and third-party libraries here
- Keep original plugin structure when possible
- Document any modifications made to plugins

### 🛠️ **Custom/**
Your own custom code libraries and implementations.

#### **Math/**
Mathematical utilities and algorithms
- `MathUtils.cs` - Common math operations and conversions
- Add custom mathematical functions here

#### **Collections/**
Data structures and collection utilities
- `ObjectPool.cs` - Generic object pooling system
- Add custom collections, data structures, and algorithms

#### **Networking/**
Network-related utilities and systems
- Network managers, serialization helpers
- Multiplayer utilities and protocols

#### **AI/**
Artificial intelligence and pathfinding
- Pathfinding algorithms
- Behavior trees and state machines
- AI utility functions

### 🌐 **ThirdParty/**
Third-party code that you've modified or customized
- Modified open-source libraries
- Custom implementations of third-party systems
- Document all changes made to original code

## 📋 Best Practices

### **For Custom Libraries:**
1. **Use clear namespaces** - Follow the `Custom.Category` pattern
2. **Document everything** - Add XML comments for all public methods
3. **Keep it modular** - Each library should have a single responsibility
4. **Version control** - Track changes and maintain compatibility

### **For Plugins:**
1. **Don't modify** - Keep original plugin files intact
2. **Document usage** - Create usage examples and documentation
3. **Test thoroughly** - Ensure plugins work with your Unity version
4. **Backup originals** - Keep copies of unmodified plugins

### **For ThirdParty:**
1. **Document changes** - Clearly mark what was modified
2. **Maintain attribution** - Keep original author credits
3. **Version tracking** - Track which version was modified
4. **License compliance** - Ensure you follow original licenses

## 🔧 Integration

### **Using Custom Libraries:**
```csharp
using Custom.Math;
using Custom.Collections;

// Use math utilities
float clampedValue = MathUtils.Clamp(value, 0f, 100f);

// Use object pooling
ObjectPool<GameObject> pool = new ObjectPool<GameObject>(prefab);
GameObject obj = pool.Get();
pool.Return(obj);
```

### **Adding New Libraries:**
1. Create appropriate subfolder in `Custom/`
2. Use consistent namespace pattern
3. Add XML documentation
4. Create usage examples
5. Update this README

## 📚 Library Categories to Consider Adding

- **Audio/** - Audio processing and management
- **Physics/** - Custom physics calculations
- **UI/** - Reusable UI components
- **Serialization/** - Data serialization helpers
- **Localization/** - Multi-language support
- **Analytics/** - Data collection and analysis
- **Security/** - Encryption and security utilities

## 🚀 Performance Considerations

- **Lazy loading** - Load libraries only when needed
- **Memory management** - Use object pooling for frequently created objects
- **Optimization** - Profile and optimize critical code paths
- **Platform-specific** - Consider different platforms when implementing

---
*Maintain this library structure for clean, reusable code organization*
