
# Installation Guide for VoicemeeterAPIWrapper

## Prerequisites

Before installing the VoicemeeterAPIWrapper, ensure that the following prerequisites are met:<br>
1. **.NET Environment:** Make sure you have a .NET compatible environment set up, such as .NET Core or .NET Framework.<br>
2. **Voicemeeter Software:** Voicemeeter must be installed on your system. You can download it from [Voicemeeter's official website](https://vb-audio.com/Voicemeeter/).<br>
3. **Voicemeeter DLLs:** The `VoicemeeterRemote.dll` and `VoicemeeterRemote64.dll` should be accessible by the application. These are typically installed with Voicemeeter.

## Step-by-Step Installation

### Step 1: Cloning or Downloading the Repository

1. Clone the repository using Git or download the source code as a ZIP file.
    ```bash
    git clone https://github.com/yourusername/VoicemeeterAPIWrapper.git
    ```
2. If downloaded as a ZIP file, extract it to your desired location.

### Step 2: Including the Wrapper in Your Project

1. Open your .NET project in your IDE.<br>
2. Add the VoicemeeterAPIWrapper project to your solution.<br>
3. Reference the VoicemeeterAPIWrapper in your project:
    - Right-click on your project in the Solution Explorer.
    - Choose "Add" > "Reference...".
    - Select the VoicemeeterAPIWrapper project.

### Step 3: Verifying DLL Accessibility

Ensure that `VoicemeeterRemote.dll` and `VoicemeeterRemote64.dll` are accessible:<br>
- They should be located in the same directory as Voicemeeter's installation or within the system's PATH environment variable.<br>
- Alternatively, copy these DLLs to your project's output directory.

### Step 4: Building the Project

Build your project to ensure that everything is correctly set up. Resolve any build errors that may arise.

## Next Steps

After successfully installing the VoicemeeterAPIWrapper, you can start using it in your project. For guidance on how to get started, refer to the [Getting Started](GETTING_STARTED.md) guide.

## Troubleshooting

If you encounter issues during the installation process, please check the [Troubleshooting](TROUBLESHOOTING.md) document or submit an issue on the GitHub repository.
