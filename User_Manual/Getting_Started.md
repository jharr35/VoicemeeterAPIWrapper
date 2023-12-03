
# Getting Started with VoicemeeterAPIWrapper

## Introduction

This guide will help you get started with the VoicemeeterAPIWrapper, a .NET library for interfacing with the Voicemeeter audio mixing application. Follow these steps to learn how to integrate and use the wrapper in your .NET projects.

## Initial Setup

Before you begin, ensure you have completed the installation steps outlined in the [Installation Guide](User_Manual/INSTALLATION.md).

## Basic Usage

### Step 1: Initializing the Wrapper

To start using the VoicemeeterAPIWrapper, you need to create an instance of the wrapper in your application. Here's a simple example:

```csharp
using VoicemeeterAPIWrapper;

// Instantiate the wrapper
var voicemeeter = new VoicemeeterAPIWrapper();
```

### Step 2: Logging In to Voicemeeter

Once you have an instance of the wrapper, you need to log in to Voicemeeter:

```csharp
// Login to Voicemeeter
bool loginSuccess = voicemeeter.Login();
if (!loginSuccess)
{
    Console.WriteLine("Error logging in to Voicemeeter");
}
```

### Step 3: Interacting with Voicemeeter

After logging in, you can start interacting with Voicemeeter. For example, to get the current version of Voicemeeter:

```csharp
string version = voicemeeter.GetVoicemeeterVersion();
Console.WriteLine($"Voicemeeter Version: {version}");
```

### Step 4: Logging Out

When you're done, make sure to log out:

```csharp
voicemeeter.Logout();
```

## Advanced Features

As you become more familiar with the wrapper, you can explore advanced features like manipulating audio levels, managing inputs/outputs, and more. Refer to the [API Reference](User_Manual/API_REFERENCE.md) for detailed information about the capabilities of the wrapper.

## Troubleshooting

If you run into any issues while using the wrapper, check the [Troubleshooting](User_Manual/TROUBLESHOOTING.md) guide for help.

## Next Steps

Now that you're familiar with the basics, start integrating the VoicemeeterAPIWrapper into your .NET projects to leverage Voicemeeter's powerful audio functionalities programmatically.
