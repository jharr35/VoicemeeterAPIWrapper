
# API Reference for VoicemeeterAPIWrapper

## Overview

This reference details the functionalities of the VoicemeeterAPIWrapper, a .NET library for interfacing with Voicemeeter audio software.

## Class: VoicemeeterAPIWrapper

### Properties

- **Is64BitApplicationRunning**: Indicates whether the application using the wrapper is 64-bit.

### Methods

#### Login

- **Login()**: Logs into Voicemeeter. Returns `true` if successful.

#### Logout

- **Logout()**: Logs out of Voicemeeter. Returns `true` if successful.

#### GetVoicemeeterType

- **GetVoicemeeterType()**: Retrieves the type of Voicemeeter installed (e.g., Voicemeeter, Banana, Potato). Returns a string representing the type.

#### GetVoicemeeterVersion

- **GetVoicemeeterVersion()**: Obtains the Voicemeeter version. Returns a string with the version information.

#### IsParameterDirty

- **IsParameterDirty()**: Checks if any Voicemeeter parameter has changed since the last check. Returns `true` if changes are detected.

#### GetParameterFloat

- **GetParameterFloat(parameterName)**: Retrieves the floating-point value of a specified parameter. `parameterName` is a string identifying the parameter. Returns the parameter value as a float.

#### SetParameterFloat

- **SetParameterFloat(parameterName, value)**: Sets the floating-point value of a specified parameter. `parameterName` is the parameter to set, and `value` is the new value. Returns `true` if successful.

#### Additional Methods

- Additional methods include `GetParameterStringA`, `SetParameterStringA`, `GetLevel`, and others for comprehensive control and interaction with Voicemeeter.

## Enums and Structures

The library includes several enums and structures to facilitate interaction with Voicemeeter, such as `VoicemeeterDeviceType`, `VoicemeeterCallBackCommand`, and `VBVMR_AUDIOINFO`.

## Conclusion

The VoicemeeterAPIWrapper provides a robust set of functionalities for .NET applications to interact with Voicemeeter. For detailed usage and examples, refer to the [Getting Started Guide](Getting_Started.md).
