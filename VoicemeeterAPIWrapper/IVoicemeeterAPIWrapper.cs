using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VoicemeeterAPIWrapperLibrary.VoicemeeterAPIWrapper;

namespace VoicemeeterAPIWrapperLibrary
{
    public interface IVoicemeeterAPIWrapper
    {
        bool Login();
        bool Logout();
        string GetVoicemeeterType();
        string GetVoicemeeterVersion();
        bool IsParameterDirty();
        float GetParameterFloat(string paramName);
        string GetParameterStringA(string paramName);
        string GetParameterStringW(string paramName);
        float GetLevel(int nType, int nuChannel);
        int GetMidiMessage(out byte[] midiBuffer);
        bool SetParameterFloat(string paramName, float value);
        bool SetParameterStringA(string paramName, string value);
        bool SetParameterStringW(string paramName, string value);
        string SetParametersA(string paramScript);
        string SetParametersW(string paramScript);
        int Output_GetDeviceNumber();
        Dictionary<string, string> Output_GetDeviceDescA(int zIndex);
        Dictionary<string, string> Output_GetDeviceDescW(int zIndex);
        int Input_GetDeviceNumber();
        Dictionary<string, string> Input_GetDeviceDescA(int zIndex);
        Dictionary<string, string> Input_GetDeviceDescW(int zIndex);
        Dictionary<int, string> AudioCallbackRegister(VoicemeeterAudioCallbackMode mode, VoicemeeterAudioCallback callbackFunction, IntPtr userData, string clientName);
        Dictionary<int, string> AudioCallbackStart();
        Dictionary<int, string> AudioCallbackStop();
        Dictionary<int, string> AudioCallbackUnregister();
        bool MacroButtonIsDirty();
        float MacroButtonGetStatus(int nuLogicalButton, VoicemeeterMacroButtonMode bitmode);
        Dictionary<int, string> MacroButtonSetStatus(int nuLogicalButton, float status, VoicemeeterMacroButtonMode bitmode);
    }
}
