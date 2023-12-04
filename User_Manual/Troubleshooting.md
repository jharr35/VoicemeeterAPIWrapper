
# Troubleshooting for VoicemeeterAPIWrapper

## Overview

This document provides guidance on troubleshooting common issues that may arise when using the VoicemeeterAPIWrapper with Voicemeeter software.

## Common Issues and Solutions

### Issue 1: Unable to Connect to Voicemeeter

**Symptoms:** Calls to `Login()` method fail, or no response from Voicemeeter.

**Possible Causes and Solutions:**
- Ensure Voicemeeter is correctly installed and running.
- Verify that the `VoicemeeterRemote.dll` and `VoicemeeterRemote64.dll` are accessible to your application.
- Check if any antivirus or firewall software is blocking the connection.

### Issue 2: Incorrect Parameter Values

**Symptoms:** Unexpected results when getting or setting parameters.

**Possible Causes and Solutions:**
- Double-check the parameter names used in methods like `GetParameterFloat` or `SetParameterFloat`.
- Ensure the parameters are being used according to Voicemeeter's documentation.

### Issue 3: Inconsistent Behavior Across Different Systems

**Symptoms:** The wrapper behaves differently on different machines.

**Possible Causes and Solutions:**
- Check the version of Voicemeeter installed on different systems. Different versions might have varied API behaviors.
- Ensure that both 32-bit and 64-bit environments are supported by your application.

### Issue 4: Application Crashes or Freezes

**Symptoms:** The application crashes or becomes unresponsive during operations.

**Possible Causes and Solutions:**
- Monitor resource usage to identify potential memory leaks or excessive CPU usage.
- Implement exception handling around API calls to gracefully handle unexpected errors.

### Issue 5: Logging and Debugging Difficulties

**Symptoms:** Difficulty in understanding or tracking down issues due to lack of logs.

**Possible Causes and Solutions:**
- Implement comprehensive logging throughout your application to capture interactions with the API.
- Use debug mode in your development environment to step through code and inspect variable states.

## General Tips

- Keep your Voicemeeter and VoicemeeterAPIWrapper versions up to date.
- Regularly review the VoicemeeterAPIWrapper documentation and release notes for updates or known issues.
- Consider reaching out to the community or support forums for assistance with specific problems.

## Contacting Support

If you encounter an issue that you're unable to resolve, please contact the Voicemeeter support team or submit an issue on the GitHub repository with detailed information about the problem.

