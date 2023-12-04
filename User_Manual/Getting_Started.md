
# Getting Started with VoicemeeterAPIWrapper

## Introduction

This document guides you through the initial setup and basic usage of the VoicemeeterAPIWrapper, a comprehensive .NET library designed for interacting with the Voicemeeter audio mixing software.

## Prerequisites

Before starting, make sure that you have Voicemeeter installed on your system and that you've followed the steps in the [Installation Guide](Installation.md) to set up the VoicemeeterAPIWrapper.

## Basic Usage

### Step 1: Initialize the Wrapper

Create an instance of `VoicemeeterAPIWrapper` in your .NET application:

```csharp
using VoicemeeterAPIWrapper;

var voicemeeter = new VoicemeeterAPIWrapper();
```

### Step 2: Log In to Voicemeeter

After creating the wrapper instance, establish a connection with Voicemeeter:

```csharp
bool loginSuccess = voicemeeter.Login();
if (!loginSuccess)
{
    // Handle login failure
    Console.WriteLine("Failed to log in to Voicemeeter.");
}
```

### Step 3: Interact with Voicemeeter

Once logged in, you can interact with Voicemeeter using various methods provided by the wrapper:

```csharp
// Example: Get the current version of Voicemeeter
string version = voicemeeter.GetVoicemeeterVersion();
Console.WriteLine($"Voicemeeter version: {version}");
```

### Step 4: Log Out

Properly log out once your operations are complete:

```csharp
voicemeeter.Logout();
```

## Conclusion

This guide covers the basics to get you started with the VoicemeeterAPIWrapper. For more detailed information on the API and its capabilities, refer to the [API Reference](API_Reference.md).
