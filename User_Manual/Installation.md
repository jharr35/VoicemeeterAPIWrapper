
# Installation Guide for VoicemeeterAPIWrapper

## Prerequisites

Before installing the VoicemeeterAPIWrapper, ensure the following requirements are met:

- **.NET Environment:** A .NET compatible environment such as .NET Core or .NET Framework is required.
- **Voicemeeter Software:** Voicemeeter must be installed on your system. Download it from [Voicemeeter's official website](https://vb-audio.com/Voicemeeter/).
- **Voicemeeter DLLs:** Ensure `VoicemeeterRemote.dll` and `VoicemeeterRemote64.dll` are accessible to your application. These DLLs are typically installed with Voicemeeter.

## Step-by-Step Installation

### Step 1: Obtain the Source Code

Clone the repository using Git or download the source code as a ZIP file:

```bash
git clone https://github.com/yourusername/VoicemeeterAPIWrapper.git
```

If downloaded as a ZIP file, extract it to your desired location.

### Step 2: Include the Wrapper in Your Project

Include the VoicemeeterAPIWrapper in your .NET project. You can do this by adding the project or the compiled DLL as a reference in your solution.

### Step 3: Ensure DLL Accessibility

Make sure the `VoicemeeterRemote.dll` and `VoicemeeterRemote64.dll` files are accessible in the runtime environment. This may involve copying them to the output directory or referencing their installation path.

## Verifying the Installation

After completing the installation steps, you can verify the successful integration by running a simple test in your application to check connectivity with Voicemeeter.

## Next Steps

After installation, you're ready to start using the VoicemeeterAPIWrapper in your projects. See the [Getting Started Guide](Getting_Started.md) for basic usage instructions.
