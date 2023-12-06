using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VoicemeeterAPIWrapperLibrary
{
    public partial class VoicemeeterAPIWrapper
    {
        // This partial class Sets all parameters that utilize an ANSI String
        // It returns a dictionary containing a result integer as well as a string describing the result

        #region Strip Parameters

        public Dictionary<int, string> SetANSIStrip_Label(int strip, string value)
        {
            string paramName = $"Strip[{strip}].Label";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set Label to {value} on Strip[{strip}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIStrip_FadeTo(int strip, float dBTarget, float msTime)
        {
            string paramName = $"Strip[{strip}].FadeTo";
            string value = $"{dBTarget}, {msTime}";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set Fade To Target dB:{dBTarget} in {msTime} ms on Strip[{strip}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },                
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIStrip_FadeBy(int strip, float dBRelativeChange, float msTime)
        {
            string paramName = $"Strip[{strip}].FadeTo";
            string value = $"{dBRelativeChange}, {msTime}";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set Fade By {dBRelativeChange}dB in {msTime} ms on Strip[{strip}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },                
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIStrip_WDM_Device(int strip, string value)
        {
            string paramName = $"Strip[{strip}].Device.wdm";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set WDM device to {value} on Strip[{strip}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },                
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIStrip_KS_Device(int strip, string value)
        {
            string paramName = $"Strip[{strip}].Device.ks";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set KS Device to {value} on Strip[{strip}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },                
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIStrip_MME_Device(int strip, string value)
        {
            string paramName = $"Strip[{strip}].Device.mme";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set MME Device to {value} on Strip[{strip}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIStrip_ASIO_Device(int strip, string value)
        {
            string paramName = $"Strip[{strip}].Device.asio";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set ASIO Device to {value} on Strip[{strip}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },                
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }
        #endregion

        #region Bus Parameters

        public Dictionary<int, string> SetANSIBus_Label(int bus, string value)
        {
            string paramName = $"Bus[{bus}].Label";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set Label to {value} on Bus[{bus}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIBus_FadeTo(int bus, float dBTarget, float msTime)
        {
            string paramName = $"Bus[{bus}].FadeTo";
            string value = $"{dBTarget}, {msTime}";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set Fade To Target dB:{dBTarget} in {msTime} ms on Bus[{bus}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIBus_FadeBy(int bus, float dBRelativeChange, float msTime)
        {
            string paramName = $"Bus[{bus}].FadeTo";
            string value = $"{dBRelativeChange}, {msTime}";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set Fade By {dBRelativeChange}dB in {msTime} ms on Bus[{bus}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIBus_WDM_Device(int bus, string value)
        {
            string paramName = $"Bus[{bus}].Device.wdm";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set WDM device to {value} on Bus[{bus}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIBus_KS_Device(int bus, string value)
        {
            string paramName = $"Bus[{bus}].Device.ks";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set KS Device to {value} on Bus[{bus}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIBus_MME_Device(int bus, string value)
        {
            string paramName = $"Bus[{bus}].Device.mme";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set MME Device to {value} on Bus[{bus}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetANSIBus_ASIO_Device(int bus, string value)
        {
            string paramName = $"Bus[{bus}].Device.asio";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set ASIO Device to {value} on Bus[{bus}] successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }
        #endregion

        #region Patch Parameters

        //There are no patch parameters that require a string

        #endregion

        #region System Settings Parameters

        // There are no System Settings that require a float

        #endregion

        #region VBAN Parameters

        public Dictionary<int, string> SetVBAN_Instream_Name(int stream, string value)
        {
            string paramName = $"vban.instream{stream}.name";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set name to {value} on VBAN Instream {stream} successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetVBAN_Instream_IP(int stream, string value)
        {
            string paramName = $"vban.instream{stream}.ip";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set IP to {value} on VBAN Instream {stream} successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetVBAN_Outstream_Name(int stream, string value)
        {
            string paramName = $"vban.outstream{stream}.name";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set name to {value} on VBAN Outstream {stream} successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetVBAN_Outstream_IP(int stream, string value)
        {
            string paramName = $"vban.outstream{stream}.ip";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterStringA64(paramName, value) : VBVMR_SetParameterStringA32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set IP to {value} on VBAN Outstream {stream} successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0)
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        #endregion

        // For all Special Command Parameters, see SetParameters-ScriptsA
    }
}
