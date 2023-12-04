
# Examples and Use Cases for VoicemeeterAPIWrapper

## Introduction

This section provides practical examples and common use cases to help you understand how to effectively utilize the VoicemeeterAPIWrapper in various scenarios.

## Basic Initialization

### Starting and Stopping the Wrapper

```csharp
using VoicemeeterAPIWrapper;

var voicemeeter = new VoicemeeterAPIWrapper();

// Starting the wrapper
voicemeeter.Login();

// Your code here...

// Stopping the wrapper
voicemeeter.Logout();
```

## Common Use Cases

### 1. Adjusting Volume Levels

Changing the volume of an input channel:

```csharp
// Set the volume of the first input channel to -6.0 dB
voicemeeter.SetParameterFloat("Strip[0].Gain", -6.0f);
```

### 2. Muting and Unmuting Channels

Toggle mute on an output bus:

```csharp
// Mute the first output bus
voicemeeter.SetParameterFloat("Bus[0].Mute", 1);

// Unmute the first output bus
voicemeeter.SetParameterFloat("Bus[0].Mute", 0);
```

### 3. Retrieving Audio Levels

Get the current level of an input channel:

```csharp
float level = voicemeeter.GetLevel(VoicemeeterAPIWrapper.LevelType.Input, 0);
Console.WriteLine($"Current level of input 0: {level}");
```

### 4. Working with Macro Buttons

Control a macro button's state:

```csharp
// Trigger a macro button
voicemeeter.MacroButtonSetStatus(1, 1.0f, VoicemeeterAPIWrapper.MacroButtonMode.Trigger);
```

## Advanced Scenarios

### Creating Custom Audio Routines

Develop custom audio processing routines by combining various API calls, such as adjusting EQ settings, routing audio signals, and managing virtual audio cables.

### Automating Audio Settings

Automate settings changes based on external triggers, such as time of day, specific application usage, or other criteria.

## Conclusion

These examples provide a starting point for integrating the VoicemeeterAPIWrapper into your application. Experiment with different methods and parameters to fully explore the capabilities of the wrapper and Voicemeeter.
