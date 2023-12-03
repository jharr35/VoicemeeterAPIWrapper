# VoicemeeterAPIWrapper for .NET

## Description

VoicemeeterAPIWrapper is a .NET library that provides an easy-to-use interface for interacting with Voicemeeter, an audio mixing application. This wrapper simplifies the process of managing audio inputs, outputs, levels, and various settings programmatically. It's designed for developers looking to integrate Voicemeeter's audio functionalities into their .NET applications.

## Getting Started

### Dependencies

- .NET compatible environment (e.g., .NET Core, .NET Framework)
- Voicemeeter installed on the system (any version)
- Voicemeeter's DLLs (`VoicemeeterRemote.dll` and `VoicemeeterRemote64.dll`) must be accessible by the application

### Installation

This package is not available on NuGet, so you'll need to include it directly in your project. Clone or download this repository and reference it in your .NET project.

### Configuration

Ensure Voicemeeter is installed and running on your system, as the wrapper interacts directly with the software.

## Usage

To use the VoicemeeterAPIWrapper, you need to instantiate it in your .NET application. Here's a simple example:

```csharp
using VoicemeeterAPIWrapper;

// Create an instance of the wrapper
var voicemeeter = new VoicemeeterAPIWrapper();

// Example: Login to Voicemeeter
bool loginSuccess = voicemeeter.Login();
if (loginSuccess)
{
    // Perform operations
}

// Logout after operations
voicemeeter.Logout();
```

Explore the various methods provided by the API wrapper for different functionalities like managing audio levels, inputs, outputs, and more.

## Features
- Interface for Voicemeeter's audio management
- Methods for getting and setting parameters
- Audio level manipulation
- Device enumeration and management
- Audio callback functionality
- Macro button controls

## Documentation
Currently, there is no separate documentation. Please refer to the inline comments in the code for detailed descriptions of methods and their usage.

## Contributing
Contributions to improve this wrapper are welcome. Please follow the standard fork-and-pull request workflow on GitHub.

## License
This project is licensed under the MIT License - see the file for details.

## Contact Information
James Harris (TygurDuck) <br>
tygurduck@gmail.com <br>
https://github.com/jharr35

## Acknowledgments
Voicemeeter for their awesome audio software - https://www.voicemeeter.com <br>
Contributors and users of this API wrapper
