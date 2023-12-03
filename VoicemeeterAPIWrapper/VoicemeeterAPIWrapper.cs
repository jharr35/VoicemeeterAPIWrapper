using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Extensions.Logging;

namespace VoicemeeterAPIWrapperLibrary
{
    public class VoicemeeterAPIWrapper
    {
        private readonly ILogger<VoicemeeterAPIWrapper> _logger;

        //Constructor
        public VoicemeeterAPIWrapper(ILogger<VoicemeeterAPIWrapper> logger)
        {
            _logger = logger;
        }

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
        }


        public static bool Is64BitApplicationRunning => GetApplicationBitness() == "64-bit";

        #region Delegates

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int VoicemeeterAudioCallback(IntPtr lpUser, VoicemeeterCallBackCommand nCommand, IntPtr lpData, int nnn);

        #endregion

        #region Structs

        [StructLayout(LayoutKind.Sequential)]
        public struct VoicemeeterAudioInfo
        {
            public int samplerate;
            public int nbSamplePerFrame;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct VoicemeeterAudioBuffer
        {
            public int audiobuffer_sr;              // Sampling rate
            public int audiobuffer_nbs;             // Number of samples per frame
            public int audiobuffer_nbi;             // Number of inputs
            public int audiobuffer_nbo;             // Number of outputs
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public IntPtr[] audiobuffer_rr;         // input pointers
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public IntPtr[] audiobuffer_w;          // output pointers       
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct VoicemeeterRealTimePacket
        {
            public byte VoicemeeterType;                // 1 = Voicemeeter, 2 = Voicemeeter Banana, 3 = Voicemeeter Potato
            public byte Reserved;                       // Unused
            public ushort BufferSize;                   // Main Stream buffer size
            public uint VoicemeeterVersion;             // Version like for VBVMR_GetVoicemeeterVersion() function
            public uint OptionBits;                     // Unused
            public uint Samplerate;                     // Main stream samplerate             

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
            public short[] InputLeveldB100;             // pre fader input peak level in dB * 100

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public short[] OutputLeveldB100;            // bus output peak level in dB * 100
                
            public uint TransportBit;                   // Transport Status

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public VoicemeeterModeState StripState;                   // Strip Buttons Status (See Mode bits below)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public VoicemeeterModeState BusState;                    // Bus Buttons Status (see Mode bits below)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] StripGaindB100Layer1;        // Strip(1) Gain in dB * 100
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] StripGaindB100Layer2;        // Strip(2) Gain in dB * 100
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] StripGaindB100Layer3;        // Strip(3) Gain in dB * 100
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] StripGaindB100Layer4;        // Strip(4) Gain in dB * 100
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] StripGaindB100Layer5;        // Strip(5) Gain in dB * 100
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] StripGaindB100Layer6;        // Strip(6) Gain in dB * 100
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] StripGaindB100Layer7;        // Strip(7) Gain in dB * 100
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] StripGaindB100Layer8;        // Strip(8) Gain in dB * 100

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public short[] BusGaindB100;                // Bus Gain in dB * 100

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 *60)]
            public string[] StripLabelUTF8c60;          // Strip Label

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 * 60)]
            public string[] BusLabelUTF8c60;            // Gain Label
        }
        #endregion

        #region Enums

        public enum VoicemeeterDeviceType
        {
            MME = 1,
            WDM = 2,
            KS = 4,
            ASIO = 5
        }

        public enum VoicemeeterCallBackCommand
        {
            Starting = 1,                   // Command to initialize data according SR and buffer size | info = (VBMR_LPT_AUDIOINFO)lpData
            Ending = 2,                     // Command to release data
            Change = 3,                     // If change in audio stream, you will have to restart audio
            Buffer_In = 10,                 // Input insert
            Buffer_Out = 11,                // Bus output insert      
            Buffer_Main = 20                // all i/o | audiobuffer = (VBVMR_LPT_AUDIOBUFFER)lpData | nnn = synchro = 1 if synchro with Voicemeeter
        }

        public enum VoicemeeterAudioCallbackMode
        {
            Input = 0x00000001,             // To process input insert
            Output = 0x00000002,            // To process output bus insert
            Main = 0x00000004               // To receive all i/o
        }


        public enum VoicemeeterMacroButtonMode
        {
            Default = 0x00000000,           // Push or Release button
            StateOnly = 0x00000002,         // Change displayed state only
            Trigger = 0x00000003            // Change trigger state
        }
        

        public enum VoicemeeterModeState
        {
            Mute =          0x00000001,
            Solo =          0x00000002,
            Mono =          0x00000004,
            MuteC =         0x00000008,

            MixDown =       0x00000010,
            Repeat =        0x00000020,
            MixDownB =      0x00000030,
            Composite =     0x00000040,
            UpMixTV =       0x00000050,
            UpMix2 =        0x00000060,
            UpMix4 =        0x00000070,
            UpMix6 =        0x00000080,
            Center =        0x00000090,
            LFE =           0x000000A0,
            Rear =          0x000000B0,

            Mask =          0x000000F0,
            
            EQ =            0x00000100,
            Cross =         0x00000200,
            EQB =           0x00000300,

            BusA =          0x00001000,
            BusA1 =         0x00002000,
            BusA2 =         0x00004000,
            BusA3 =         0x00008000,
            BusA5 =         0x00080000,

            BusB =          0x00010000,
            BusB1 =         0x00010000,
            BusB2 =         0x00020000,
            BusB3 =         0x00040000,

            Pan0 =          0x00000000,
            PanColor =      0x00100000,
            PanMod =        0x00200000,
            PanMask =       0x00F00000,

            PostFX_R =      0x01000000,
            PostFX_D =      0x02000000,
            PostFX1 =       0x04000000,
            PostFX2 =       0x08000000,

            SEL =           0x10000000,
            Monitor =       0x20000000
        }
        #endregion

        #region DLL Imports

        #region Login
        //Importing the VBVMR_Login function from the DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_Login")]
        private static extern int VBVMR_Login32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_Login")]
        private static extern int VBVMR_Login64();

        //Importing the VBVMR_Logout function from the DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_Logout")]
        private static extern int VBVMR_Logout32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_Logout")]
        private static extern int VBVMR_Logout64();
        #endregion

        #region General Information
        //Importing the VBVMR_GetVoicemeeterType function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_GetVoicemeeterType")]
        private static extern int VBVMR_GetVoicemeeterType32(ref int pType);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_GetVoicemeeterType")]
        private static extern int VBVMR_GetVoicemeeterType64(ref int pType);

        //Importing the VBVMR_GetVoicemeeterVersion function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_GetVoicemeeterVersion")]
        private static extern int VBVMR_GetVoicemeeterVersion32(ref long pVersion);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_GetVoicemeeterVersion")]
        private static extern int VBVMR_GetVoicemeeterVersion64(ref long pVersion);
        #endregion

        #region Get Parameters
        //Importing the VBVMR_IsParameterDirty function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_IsParameterDirty")]
        private static extern int VBVMR_IsParameterDirty32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_IsParameterDirty")]
        private static extern int VBVMR_IsParameterDirty64();

        //Importing the VBVMR_GetParameterFloat function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_GetParameterFloat")]
        private static extern int VBVMR_GetParameterFloat32(string paramName, ref float pValue);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_GetParameterFloat")]
        private static extern int VBVMR_GetParameterFloat64(string paramName, ref float pValue);

        //Importing the VBVMR_GetParameterStringA function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_GetParameterStringA", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_GetParameterStringA32(string paramName, StringBuilder szString);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_GetParameterStringA", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_GetParameterStringA64(string paramName, StringBuilder szString);

        //Importing the VBVMR_GetParameterStringW function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_GetParameterStringW", CharSet = CharSet.Unicode)]
        private static extern int VBVMR_GetParameterStringW32(string paramName, StringBuilder szString);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_GetParameterStringW", CharSet = CharSet.Unicode)]
        private static extern int VBVMR_GetParameterStringW64(string paramName, StringBuilder szString);
        #endregion

        #region Get Levels
        //Importing the VBVMR_GetLevel function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_GetLevel")]
        private static extern int VBVMR_GetLevel32(int nType, int nuChannel, ref float pValue);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_GetLevel")]
        private static extern int VBVMR_GetLevel64(int nType, int nuChannel, ref float pValue);

        //Importing the VBVMR_GetMidiMessage function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_GetMidiMessage")]
        private static extern int VBVMR_GetMidiMessage32(byte[] pMIDIBuffer, int nbByteMax);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_GetMidiMessage")]
        private static extern int VBVMR_GetMidiMessage64(byte[] pMIDIBuffer, int nbByteMax);
        #endregion

        #region Set Parameters
        //Importing the VBVMR_SetParameterFloat function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_SetParameterFloat")]
        private static extern int VBVMR_SetParameterFloat32(string paramName, float value);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_SetParameterFloat")]
        private static extern int VBVMR_SetParameterFloat64(string paramName, float value);

        //Importing the VBVMR_SetParameterStringA function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_SetParameterStringA", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_SetParameterStringA32(string paramName, string szString);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_SetParameterStringA", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_SetParameterStringA64(string paramName, string szString);

        //Importing the VBVMR_SetParameterStringW function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_SetParameterStringW", CharSet = CharSet.Unicode)]
        private static extern int VBVMR_SetParameterStringW32(string paramName, string szString);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_SetParameterStringW", CharSet = CharSet.Unicode)]
        private static extern int VBVMR_SetParameterStringW64(string paramName, string szString);

        //Importing the VBVMR_SetParameters function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_SetParameters", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_SetParameters32(string paramScript);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_SetParameters", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_SetParameters64(string paramScript);

        //Importing the VBVMR_SetParametersW function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_SetParametersW", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_SetParametersW32(string paramScript);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_SetParametersW", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_SetParametersW64(string paramScript);
        #endregion

        #region Devices Enumerator
        //Importing the VBVMR_Output_GetDeviceNumber function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_Output_GetDeviceNumber")]
        private static extern int VBVMR_Output_GetDeviceNumber32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_Output_GetDeviceNumber")]
        private static extern int VBVMR_Output_GetDeviceNumber64();

        //Importing the VBVMR_Output_GetDeviceDescA function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_Output_GetDeviceDescA", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_Output_GetDeviceDescA32(int zIndex, out VoicemeeterDeviceType nType, StringBuilder szDeviceName, StringBuilder szHardwareId);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_Output_GetDeviceDescA", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_Output_GetDeviceDescA64(int zIndex, out VoicemeeterDeviceType nType, StringBuilder szDeviceName, StringBuilder szHardwareId);

        //Importing the VBVMR_Output_GetDeviceDescW function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_Output_GetDeviceDescW", CharSet = CharSet.Unicode)]
        private static extern int VBVMR_Output_GetDeviceDescW32(int zIndex, out VoicemeeterDeviceType nType, StringBuilder szDeviceName, StringBuilder szHardwareId);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_Output_GetDeviceDescW", CharSet = CharSet.Unicode)]
        private static extern int VBVMR_Output_GetDeviceDescW64(int zIndex, out VoicemeeterDeviceType nType, StringBuilder szDeviceName, StringBuilder szHardwareId);

        //Importing the VBVMR_Input_GetDeviceNumber function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_Input_GetDeviceNumber")]
        private static extern int VBVMR_Input_GetDeviceNumber32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_Input_GetDeviceNumber")]
        private static extern int VBVMR_Input_GetDeviceNumber64();

        //Importing the VBVMR_Input_GetDeviceDescA function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_Input_GetDeviceDescA", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_Input_GetDeviceDescA32(int zIndex, out VoicemeeterDeviceType nType, StringBuilder szDeviceName, StringBuilder szHardwareId);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_Input_GetDeviceDescA", CharSet = CharSet.Ansi)]
        private static extern int VBVMR_Input_GetDeviceDescA64(int zIndex, out VoicemeeterDeviceType nType, StringBuilder szDeviceName, StringBuilder szHardwareId);

        //Importing the VBVMR_Input_GetDeviceDescW function from DLL
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_Input_GetDeviceDescW", CharSet = CharSet.Unicode)]
        private static extern int VBVMR_Input_GetDeviceDescW32(int zIndex, out VoicemeeterDeviceType nType, StringBuilder szDeviceName, StringBuilder szHardwareId);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_Input_GetDeviceDescW", CharSet = CharSet.Unicode)]
        private static extern int VBVMR_Input_GetDeviceDescW64(int zIndex, out VoicemeeterDeviceType nType, StringBuilder szDeviceName, StringBuilder szHardwareId);
        #endregion

        #region VB-Audio Callback
        // The VBVMR_AudioCallbackRegister function
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_AudioCallbackRegister")]
        public static extern int AudioCallbackRegister32(VoicemeeterAudioCallbackMode mode, VoicemeeterAudioCallback pCallback, IntPtr lpUser, string szClientName);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_AudioCallbackRegister")]
        public static extern int AudioCallbackRegister64(VoicemeeterAudioCallbackMode mode, VoicemeeterAudioCallback pCallback, IntPtr lpUser, string szClientName);

        // The VBVMR_AudioCallbackStart function
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_AudioCallbackStart")]
        public static extern int AudioCallbackStart32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_AudioCallbackStart")]
        public static extern int AudioCallbackStart64();

        // The VBVMR_AudioCallbackStop function
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_AudioCallbackStop")]
        public static extern int AudioCallbackStop32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_AudioCallbackStop")]
        public static extern int AudioCallbackStop64();

        // The VBVMR_AudioCallbackUnregister function
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_AudioCallbackUnregister")]
        public static extern int AudioCallbackUnregister32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_AudioCallbackUnregister")]
        public static extern int AudioCallbackUnregister64();
        #endregion

        #region Macro Buttons
        // The VBVMR_MacroButton_IsDirty function
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_MacroButton_IsDirty")]
        public static extern int MacroButtonIsDirty32();

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_MacroButton_IsDirty")]
        public static extern int MacroButtonIsDirty64();

        // The VBVMR_MacroButton_GetStatus function
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_MacroButton_GetStatus")]
        public static extern int MacroButtonGetStatus32(long nuLogicalButton, ref float pValue, VoicemeeterMacroButtonMode bitmode);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_MacroButton_GetStatus")]
        public static extern int MacroButtonGetStatus64(long nuLogicalButton, ref float pValue, VoicemeeterMacroButtonMode bitmode);

        // The VBVMR_MacroButton_SetStatus function
        [DllImport("VoicemeeterRemote.dll", EntryPoint = "VBVMR_MacroButton_SetStatus")]
        public static extern int MacroButtonSetStatus32(long nuLogicalButton, ref float pValue, VoicemeeterMacroButtonMode bitmode);

        [DllImport("VoicemeeterRemote64.dll", EntryPoint = "VBVMR_MacroButton_SetStatus")]
        public static extern int MacroButtonSetStatus64(long nuLogicalButton, ref float pValue, VoicemeeterMacroButtonMode bitmode);
        #endregion

        #endregion

        #region Wrappers

        //Method returns if developed app using wrapper is 64-bit or 32-bit
        public static string GetApplicationBitness()
        {
            if (Environment.Is64BitProcess)
                return "64-bit";
            else
                return "32-bit";
        }

        #region Login
        //Wrapper method Login
        public bool Login()
        {
            return Is64BitApplicationRunning ? VBVMR_Login64() == 0 : VBVMR_Login32() == 0;
        }

        //Wrapper method Logout
        public bool Logout()
        {
            return Is64BitApplicationRunning ? VBVMR_Logout64() == 0 : VBVMR_Logout32() == 0;
        }
        #endregion

        #region General Information
        //Wrapper method GetVoicemeeterType
        public string GetVoicemeeterType()
        {
            int pType = 0;
            int result = Is64BitApplicationRunning ? VBVMR_GetVoicemeeterType64(ref pType) : VBVMR_GetVoicemeeterType32(ref pType);
            if (result == 0) // Check if the call was successful
            {
                return pType switch
                {
                    1 => "Voicemeeter",
                    2 => "Voicemeeter Banana",
                    3 => "Voicemeeter Potato",
                    _ => "Unknown Type",
                };
            }
            else
            {
                _logger.LogError("Version Unknown");
                return "Version Unknown";
            }
        }

        //Wrapper for method GetVoicemeeterVersion
        public string GetVoicemeeterVersion()
        {
            long pVersion = 0;
            int result = Is64BitApplicationRunning ? VBVMR_GetVoicemeeterVersion32(ref pVersion) : VBVMR_GetVoicemeeterVersion64(ref pVersion);

            if (result == 0)
            {
                int v1 = (int)(pVersion & 0xFF000000) >> 24;
                int v2 = (int)(pVersion & 0x00FF0000) >> 16;
                int v3 = (int)(pVersion & 0x0000FF00) >> 8;
                int v4 = (int)(pVersion & 0x000000FF);

                return $"Version {v1}.{v2}.{v3}.{v4}";
            }
            else
            {
                _logger.LogError("Version Unknown");
                return "Version Unknown";
            }
        }
        #endregion

        #region Get Parameters
        //Wrapper for method IsParameterDirty
        public bool IsParameterDirty()
        {
            int result = Is64BitApplicationRunning ? VBVMR_IsParameterDirty64() : VBVMR_IsParameterDirty32();

            return result switch
            {
                0 => false,     //No changes to parameters
                _ => true,      //Changes found -> update display
            };
        }

        //Wrapper for method GetParameterFloat
        public float GetParameterFloat(string paramName)
        {
            float pValue = 0f;
            int result = Is64BitApplicationRunning ? VBVMR_GetParameterFloat64(paramName, ref pValue) : VBVMR_GetParameterFloat32(paramName, ref pValue);

            if (result == 0)
                return pValue;
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot get client (unexpected)",
                    -2 => "Error: no server",
                    _ => $"Unknown error: result = {result}"
                };

               _logger.LogError(errorMessage);
                return float.NaN;
            }
        }

        //Wrapper for method GetParameterStringA
        public string GetParameterStringA(string paramName)
        {
            StringBuilder szString = new StringBuilder(512);

            int result = Is64BitApplicationRunning ? VBVMR_GetParameterStringA64(paramName, szString) : VBVMR_GetParameterStringA32(paramName, szString);

            if (result == 0)
            {
                return szString.ToString();
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot get client (unexpected)",
                    -2 => "Error: no server",
                    -3 => "Error: unknown parameter",
                    -5 => "Error: structure mismatch",
                    _ => $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return string.Empty;
            }
        }

        //Wrapper for method GetParameterStringW
        public string GetParameterStringW(string paramName)
        {
            StringBuilder szString = new StringBuilder(512);

            int result = Is64BitApplicationRunning ? VBVMR_GetParameterStringA64(paramName, szString) : VBVMR_GetParameterStringA32(paramName, szString);

            if (result == 0)
            {
                return szString.ToString();
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot get client (unexpected)",
                    -2 => "Error: no server",
                    -3 => "Error: unknown parameter",
                    -5 => "Error: structure mismatch",
                    _ => $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return string.Empty;
            }
        }
        #endregion

        #region Levels
        //Wrapper for method GetLevel
        public float GetLevel(int nType, int nuChannel)
        {
            float pValue = 0f;
            
            int result = Is64BitApplicationRunning ? VBVMR_GetLevel64(nType, nuChannel, ref pValue) : VBVMR_GetLevel32(nType, nuChannel, ref pValue);

            if (result == 0)
            {
                return pValue;
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot get client (unexpected)",
                    -2 => "Error: no server",
                    -3 => "Error: no level available",
                    -4 => "Error: out of range",
                    _ => $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return float.NaN;
            }
        }

        public int GetMidiMessage(out byte[] midiBuffer)
        {
            midiBuffer = new byte[1024];
            int result = Is64BitApplicationRunning ? VBVMR_GetMidiMessage64(midiBuffer, midiBuffer.Length) : VBVMR_GetMidiMessage32(midiBuffer, midiBuffer.Length);

            if (result >= 0)
            {
                return result;
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot get client (unexpected)",
                    -2 => "Error: no server",
                    -5 => "Error: no MIDI data",
                    -6 => "Error: no MIDI Data",
                    _ => $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return Int32.MinValue;
            }
        }
        #endregion

        #region Set Parameters
        //Wrapper for method SetParameterFloat
        public bool SetParameterFloat(string paramName, float value)
        {
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            if (result == 0)
            {
                return true;
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot get client (unexplained)",
                    -2 => "Error: no server",
                    -3 => "Error: unknown parameter",
                    _ => $"Uknown eror: result = {result}"
                };

                _logger.LogError(errorMessage);
                return false;
            }
        }

        //Wrapper for method SetParameterStringA
        public bool SetParameterStringA(string paramName, string value)
        {
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            if (result == 0)
            {
                return true;
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot find client (unexplained)",
                    -2 => "Error: no server",
                    -3 => "Error: unknown parameter",
                    _ => $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return false;
            }
        }

        //Wrapper for method SetParameterStringW
        public bool SetParameterStringW(string paramName, string value)
        {
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringW64(paramName, value) : VBVMR_SetParameterStringW32(paramName, value);

            if (result == 0)
            {
                return true;
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot find client (unexplained)",
                    -2 => "Error: no server",
                    -3 => "Error: unknown parameter",
                    _ => $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return false;
            }
        }

        //Wrapper for method SetParameters
        public string SetParameters(string paramScript)
        {
            int result = Is64BitApplicationRunning ? VBVMR_SetParameters64(paramScript) : VBVMR_SetParameters32(paramScript);

            if (result == 0)
            {
                return "SetParameters successful";
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot find client (unexplained)",
                    -2 => "Error: no server",
                    -3 => "Error: unexpected error",
                    -4 => "Error: unexpected error",
                    _ => result > 0 ? $"Error: Script error at line {result}" : $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return errorMessage;
            }
        }

        //Wrapper for method SetParametersW
        public string SetParametersW(string paramScript)
        {
            int result = Is64BitApplicationRunning ? VBVMR_SetParametersW64(paramScript) : VBVMR_SetParametersW32(paramScript);

            if (result == 0)
            {
                return "SetParametersW Successful";
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: cannot find client (unexplained)",
                    -2 => "Error: no server",
                    -3 => "Error: unexpected error",
                    -4 => "Error: unexpected error",
                    _ => result > 0 ? $"Error: Script error at line {result}" : $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return errorMessage;
            }
        }
        #endregion

        #region Devices Enumerator
        //Wrapper for method Output_GetDeviceNumber
        public int Output_GetDeviceNumber()
        {
            int result = Is64BitApplicationRunning ? VBVMR_Output_GetDeviceNumber64() : VBVMR_Output_GetDeviceNumber32();

            if (result >= 0)
            {
                return result;
            }
            else
            {
                _logger.LogError($"Unknown error: result = {result}");
                return Int32.MinValue;
            }
        }

        //Wrapper for method Output_GetDeviceDescA
        public Dictionary<string,string> Output_GetDeviceDescA(int zIndex)
        {
            VoicemeeterDeviceType nType;
            StringBuilder szDeviceName = new StringBuilder(512);
            StringBuilder szHardwareId = new StringBuilder(512);

            int result = Is64BitApplicationRunning ? VBVMR_Output_GetDeviceDescA64(zIndex, out nType, szDeviceName, szHardwareId) : VBVMR_Output_GetDeviceDescA32(zIndex, out nType, szDeviceName, szHardwareId);

            if (result == 0)
                return new Dictionary<string, string>
                {
                    { "Index", zIndex.ToString() },
                    { "Type", nType.ToString() },
                    { "Name", szDeviceName.ToString() },
                    { "Id", szHardwareId.ToString() },
                    { "Result", "Success" }
                };
            else
            {
                string errorMessage = $"Unknown error: result = {result}";
                _logger.LogError(errorMessage);

                return new Dictionary<string, string>
                {
                    { "Index", zIndex.ToString() },
                    { "Type", "" },
                    { "Name", "" },
                    { "Id", "" },
                    { "Result", errorMessage }
                };
            }
        }

        //Wrapper for method Output_GetDeviceDescW
        public Dictionary<string, string> Output_GetDeviceDescW(int zIndex)
        {
            VoicemeeterDeviceType nType;
            StringBuilder szDeviceName = new StringBuilder(512);
            StringBuilder szHardwareId = new StringBuilder(512);

            int result = Is64BitApplicationRunning ? VBVMR_Output_GetDeviceDescA64(zIndex, out nType, szDeviceName, szHardwareId) : VBVMR_Output_GetDeviceDescA32(zIndex, out nType, szDeviceName, szHardwareId);

            if (result == 0)
            {
                return new Dictionary<string, string>
                {
                    { "Index", zIndex.ToString() },
                    { "Type", nType.ToString() },
                    { "Name", szDeviceName.ToString() },
                    { "Id", szHardwareId.ToString() },
                    { "Result", "Success" }
                };
            }
            else
            {
                string errorMessage = $"Unknown error: result = {result}";
                _logger.LogError(errorMessage);

                return new Dictionary<string, string>
                {
                    { "Index", zIndex.ToString() },
                    { "Type", "" },
                    { "Name", "" },
                    { "Id", "" },
                    { "Result", errorMessage }
                };
            }
        }

        //Wrapper for method Input_GetDeviceNumber
        public int Input_GetDeviceNumber()
        {
            int result = Is64BitApplicationRunning ? VBVMR_Input_GetDeviceNumber64() : VBVMR_Input_GetDeviceNumber32();

            if (result >= 0)
            {
                return result;
            }
            else
            {
                _logger.LogError($"Unknown error: result = {result}");
                return Int32.MinValue;
            }
        }

        //Wrapper for method Input_GetDeviceDescA
        public Dictionary<string, string> Input_GetDeviceDescA(int zIndex)
        {
            VoicemeeterDeviceType nType;
            StringBuilder szDeviceName = new StringBuilder(512);
            StringBuilder szHardwareId = new StringBuilder(512);

            int result = Is64BitApplicationRunning ? VBVMR_Input_GetDeviceDescA64(zIndex, out nType, szDeviceName, szHardwareId) : VBVMR_Input_GetDeviceDescA32(zIndex, out nType, szDeviceName, szHardwareId);

            if (result == 0)
            {
                return new Dictionary<string, string>
                {
                    { "Index", zIndex.ToString() },
                    { "Type", nType.ToString() },
                    { "Name", szDeviceName.ToString() },
                    { "Id", szHardwareId.ToString() },
                    { "Result", "Success" }
                };
            }
            else
            {
                string errorMessage = $"Unknown error: result = {result}";
                _logger.LogError(errorMessage);

                return new Dictionary<string, string>
                {
                    { "Index", zIndex.ToString() },
                    { "Type", "" },
                    { "Name", "" },
                    { "Id", "" },
                    { "Result", errorMessage }
                };
            }
        }

        //Wrapper for method Input_GetDeviceDescW
        public Dictionary<string, string> Input_GetDeviceDescW(int zIndex)
        {
            VoicemeeterDeviceType nType;
            StringBuilder szDeviceName = new StringBuilder(512);
            StringBuilder szHardwareId = new StringBuilder(512);

            int result = Is64BitApplicationRunning ? VBVMR_Input_GetDeviceDescA64(zIndex, out nType, szDeviceName, szHardwareId) : VBVMR_Input_GetDeviceDescA32(zIndex, out nType, szDeviceName, szHardwareId);

            if (result == 0)
            {
                return new Dictionary<string, string>
                {
                    { "Index", zIndex.ToString() },
                    { "Type", nType.ToString() },
                    { "Name", szDeviceName.ToString() },
                    { "Id", szHardwareId.ToString() },
                    { "Result", "Success" }
                };
            }
            else
            {
                string errorMessage = $"Unknown error: result = {result}";
                _logger.LogError(errorMessage);
                return new Dictionary<string, string>
                {
                    { "Index", zIndex.ToString() },
                    { "Type", "" },
                    { "Name", "" },
                    { "Id", "" },
                    { "Result", errorMessage }
                };
            }
        }
        #endregion

        #region Audio Callback
        //Wrapper for method AudioCallbackRegister
        public Dictionary<int, string> AudioCallbackRegister(VoicemeeterAudioCallbackMode mode, VoicemeeterAudioCallback callbackDelegate, IntPtr userData, string clientName)
        {
            int result = Is64BitApplicationRunning ? AudioCallbackRegister64(mode, callbackDelegate, userData, clientName) : AudioCallbackRegister32(mode, callbackDelegate, userData, clientName);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Successful (no errors)" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot find client (unexplained)" } },
                1 => new Dictionary<int, string> { { result, "Callback already registered (by another application" } },
                _ => new Dictionary<int, string> { { result, $"Unknown error: result = {result}" } }
            };

            _logger.LogError(resultMessage.ToString());
            return resultMessage;
        }

        //Wrapper for method AudioCallbackStart
        public Dictionary<int, string> AudioCallbackStart()
        {
            int result = Is64BitApplicationRunning ? AudioCallbackStart64() : AudioCallbackStart32();

            Dictionary<int,string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Successful (no errors)" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot find client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Callback already registered" } },
                _ => new Dictionary<int, string> { { result, $"Unknown error: result = {result}" } }
            };

            _logger.LogError(resultMessage.ToString());
            return resultMessage;
        }

        //Wrapper for method AudioCallbackStop
        public Dictionary<int, string> AudioCallbackStop()
        {
            int result = Is64BitApplicationRunning ? AudioCallbackStop64() : AudioCallbackStop32();

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Successful (no errors)" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot find client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Callback already registered" } },
                _ => new Dictionary<int, string> { { result, $"Unknown error: result = {result}" } }
            };

            _logger.LogError(resultMessage.ToString());
            return resultMessage;
        }

        //Wrapper for method AudioCallbackUnregister
        public Dictionary<int, string> AudioCallbackUnregister()
        {
            int result = Is64BitApplicationRunning ? AudioCallbackUnregister64() : AudioCallbackUnregister32();

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Successful (no errors)" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot find client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Callback already registered" } },
                _ => new Dictionary<int, string> { {  result, $"Unknown error: result = {result}" }}
            };

            _logger.LogError(resultMessage.ToString());
            return resultMessage;
        }
        #endregion

        #region Macro Buttons
        //Wrapper method for MacroButtonIsDirty
        public bool MacroButtonIsDirty()
        {
            int result = Is64BitApplicationRunning ? MacroButtonIsDirty64() : MacroButtonIsDirty32();

            if (result == 0)
                return false;
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: client cannot be found (unexplained)",
                    -2 => "Error: no server",
                    _ => result > 0 ? "" : $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage);
                return true;
            }
        }

        //Wrapper method for MacroButtonGetStatus
        public float MacroButtonGetStatus(int nuLogicalButton, VoicemeeterMacroButtonMode bitmode)
        {
            float pValue = 0f;
            int result = Is64BitApplicationRunning ? MacroButtonGetStatus64(nuLogicalButton, ref pValue, bitmode) : MacroButtonGetStatus32(nuLogicalButton, ref pValue, bitmode);

            if (result == 0)
            {
                return pValue;
            }
            else
            {
                string errorMessage = result switch
                {
                    -1 => "Error: no client found (unexplained)",
                    -2 => "Error: no server",
                    -3 => "Error: unknown parameter",
                    -5 => "Error: structure mismatch",
                    _ => $"Unknown error: result = {result}"
                };

                _logger.LogError(errorMessage); 
                return float.NaN;
            }
        }

        public string MacroButtonSetStatus(int nuLogicalButton, float status, VoicemeeterMacroButtonMode bitmode)
        {
            int result = Is64BitApplicationRunning ? MacroButtonSetStatus64(nuLogicalButton, ref status, bitmode) : MacroButtonSetStatus32(nuLogicalButton, ref status, bitmode);

            string resultMessage = result switch
            {
                0 => "Successful",
                -1 => "Error: no client found (unexplained)",
                -2 => "Error: no server",
                -3 => "Error: unknown parameter",
                -5 => "Error: structure mismatch",
                _ => $"Unknown error: result = {result}"
            };

            _logger.LogError(resultMessage);
            return resultMessage;
        }
        #endregion

        #endregion


    }
}