
# API Reference for VoicemeeterAPIWrapper

## Overview

This document provides a detailed reference for the VoicemeeterAPIWrapper, a .NET library designed to interact with the Voicemeeter audio software.

## Class: VoicemeeterAPIWrapper

### Properties
- `Is64BitApplicationRunning`: Indicates if the application using the wrapper is 64-bit.

### Methods

#### Login
- `Login()`: Logs into Voicemeeter. Returns `true` if successful.

#### Logout
- `Logout()`: Logs out of Voicemeeter. Returns `true` if successful.

#### GetVoicemeeterType
- `GetVoicemeeterType()`: Gets the type of Voicemeeter installed (e.g., Voicemeeter, Banana, Potato). Returns a string representing the type.

#### GetVoicemeeterVersion
- `GetVoicemeeterVersion()`: Gets the version of Voicemeeter. Returns a string with the version number.

#### IsParameterDirty
- `IsParameterDirty()`: Checks if any Voicemeeter parameter has changed since the last call. Returns `true` if changes are detected.

#### GetParameterFloat
- `GetParameterFloat(string paramName)`: Gets a parameter value as a float. Returns the parameter value.

#### GetParameterStringA
- `GetParameterStringA(string paramName)`: Gets a parameter value as an ANSI string. Returns the parameter value.

#### GetParameterStringW
- `GetParameterStringW(string paramName)`: Gets a parameter value as a Unicode string. Returns the parameter value.

#### GetLevel
- `GetLevel(int nType, int nuChannel)`: Gets the level of a specific channel. Returns the level as a float.

#### GetMidiMessage
- `GetMidiMessage(out byte[] midiBuffer)`: Retrieves MIDI messages. Returns the length of the MIDI message.

#### SetParameterFloat
- `SetParameterFloat(string paramName, float value)`: Sets a parameter value as a float.

#### SetParameterStringA
- `SetParameterStringA(string paramName, string value)`: Sets a parameter value as an ANSI string.

#### SetParameterStringW
- `SetParameterStringW(string paramName, string value)`: Sets a parameter value as a Unicode string.

#### SetParameters
- `SetParameters(string paramScript)`: Sets multiple parameters based on a script.

#### Output_GetDeviceNumber
- `Output_GetDeviceNumber()`: Gets the number of output devices. Returns the number of devices.

#### Output_GetDeviceDescA
- `Output_GetDeviceDescA(int zIndex)`: Gets the description of an output device. Returns a string with the device description.

#### Input_GetDeviceNumber
- `Input_GetDeviceNumber()`: Gets the number of input devices. Returns the number of devices.

#### Input_GetDeviceDescA
- `Input_GetDeviceDescA(int zIndex)`: Gets the description of an input device. Returns a string with the device description.

## Enums

### VoicemeeterDeviceType
- `MME`, `WDM`, `KS`, `ASIO`

### VoicemeeterCallBackCommand
- Various callback commands like `Starting`, `Ending`, `Change`, etc.

### VoicemeeterAudioCallbackMode
- `Input`, `Output`, `Main`

### VoicemeeterMacroButtonMode
- `Default`, `StateOnly`, `Trigger`

### VoicemeeterModeState
- Various states like `Mute`, `Solo`, `Mono`, etc.

## Structs

### VoicemeeterAudioInfo
- Contains audio information like `samplerate` and `nbSamplePerFrame`.

### VoicemeeterAudioBuffer
- Contains audio buffer information.

### VoicemeeterRealTimePacket
- Contains various information about the Voicemeeter packets.

## Notes
- The above descriptions provide a basic overview of each class, method, enum, and struct. For detailed usage, refer to the specific method documentation and the Voicemeeter SDK documentation available on GitHub.

## Further Information
For more details on using the Voicemeeter API and handling specific audio processing scenarios, refer to the official [Voicemeeter Remote API documentation](https://github.com/vburel2018/Voicemeeter-SDK).
