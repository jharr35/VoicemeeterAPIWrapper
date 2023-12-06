using Microsoft.Extensions.Logging;

namespace VoicemeeterAPIWrapperLibrary
{
    public partial class VoicemeeterAPIWrapper
    {
        // This partial class Sets all parameters that utilize a float
        // It returns a dictionary containing a result integer as well as a string describing the result

        #region Strip Parameters
        public Dictionary<int, string> SetStrip_Gain(int strip, float value)
        {
            string paramName = $"Strip[{strip}.gain";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Gain Successful" } },
                -1 => new Dictionary<int, string> { { result, "Error: cannot get client (unexplained)" } },
                -2 => new Dictionary<int, string> { { result, "Error: no server" } },
                -3 => new Dictionary<int, string> { { result, "Error: unknown parameter" } },
                _ => new Dictionary<int, string> { { result, $"Unknown eror: result = {result}" } }
            };

            if (result == 0 )
            {
                return resultMessage;
            }
            else
            {
                _logger.LogError(resultMessage.ToString());
                return resultMessage;
            }
        }

        public Dictionary<int, string> SetStrip_A1(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.A1";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A1 Successful" } },
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

        public Dictionary<int, string> SetStrip_A2(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.A2";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A2 Successful" } },
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

        public Dictionary<int, string> SetStrip_A3(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.A3";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A3 Successful" } },
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

        public Dictionary<int, string> SetStrip_A4(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.A4";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A4 Successful" } },
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

        public Dictionary<int, string> SetStrip_A5(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.A5";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A5 Successful" } },
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

        public Dictionary<int, string> SetStrip_B1(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.B1";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set B1 Successful" } },
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

        public Dictionary<int, string> SetStrip_B2(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.B2";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set B2 Successful" } },
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

        public Dictionary<int, string> SetStrip_B3(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.B3";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set B3 Successful" } },
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

        public Dictionary<int, string> SetStrip_Mono(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.Mono";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Mono Successful" } },
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

        public Dictionary<int, string> SetStrip_Mute(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.Mute";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Mute Successful" } },
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

        public Dictionary<int, string> SetStrip_Solo(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.Solo";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Solo Successful" } },
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

        public Dictionary<int, string> SetStrip_MC(int strip, bool onOff)
        {
            string paramName = $"Strip[{strip}.MC";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Mute Center Successful" } },
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

        public Dictionary<int, string> SetStrip_PanX(int strip, float value)
        {
            string paramName = $"Strip[{strip}.Pan_x";
         
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Pan X Successful" } },
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

        public Dictionary<int, string> SetStrip_PanY(int strip, float value)
        {
            string paramName = $"Strip[{strip}.Pan_y";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Pan Y Successful" } },
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

        public Dictionary<int, string> SetStrip_ColorX(int strip, float value) // Physical Strip Only
        {
            string paramName = $"Strip[{strip}.Color_x";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Color X Successful" } },
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

        public Dictionary<int, string> SetStrip_ColorY(int strip, float value) // Physical Strip Only
        {
            string paramName = $"Strip[{strip}.Color_y";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Color Y Successful" } },
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

        public Dictionary<int, string> SetStrip_Audibility(int strip, float value) //Voicemeeter 1 only
        {
            string paramName = $"Strip[{strip}.Audibility";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Pan Y Successful" } },
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

        public Dictionary<int, string> SetStrip_EQGain1(int strip, float value) // Virtual Strip Only
        {
            string paramName = $"Strip[{strip}.EQGain1";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set EQ Gain1 Successful" } },
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

        public Dictionary<int, string> SetStrip_EQGain2(int strip, float value) // Virtual Strip Only
        {
            string paramName = $"Strip[{strip}.EQGain2";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set EQ Gain 2 Successful" } },
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

        public Dictionary<int, string> SetStrip_EQGain3(int strip, float value) // Virtual Strip Only
        {
            string paramName = $"Strip[{strip}.EQGain3";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set EQ Gain 3 Successful" } },
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

        #region BUS Parameters
        public Dictionary<int, string> SetBus_Gain(int bus, float value)
        {
            string paramName = $"Bus[{bus}.gain";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Gain Successful" } },
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

        public Dictionary<int, string> SetBus_A1(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.A1";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A1 Successful" } },
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

        public Dictionary<int, string> SetBus_A2(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.A2";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A2 Successful" } },
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

        public Dictionary<int, string> SetBus_A3(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.A3";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A3 Successful" } },
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

        public Dictionary<int, string> SetBus_A4(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.A4";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A4 Successful" } },
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

        public Dictionary<int, string> SetBus_A5(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.A5";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set A5 Successful" } },
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

        public Dictionary<int, string> SetBus_B1(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.B1";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set B1 Successful" } },
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

        public Dictionary<int, string> SetBus_B2(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.B2";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set B2 Successful" } },
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

        public Dictionary<int, string> SetBus_B3(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.B3";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set B3 Successful" } },
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

        public Dictionary<int, string> SetBus_Mono(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.Mono";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Mono Successful" } },
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

        public Dictionary<int, string> SetBus_Mute(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.Mute";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Mute Successful" } },
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

        public Dictionary<int, string> SetBus_Solo(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.Solo";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Solo Successful" } },
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

        public Dictionary<int, string> SetBus_MC(int bus, bool onOff)
        {
            string paramName = $"Bus[{bus}.MC";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Mute Center Successful" } },
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

        public Dictionary<int, string> SetBus_PanX(int bus, float value)
        {
            string paramName = $"Bus[{bus}.Pan_x";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Pan X Successful" } },
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

        public Dictionary<int, string> SetBus_PanY(int bus, float value)
        {
            string paramName = $"Bus[{bus}.Pan_y";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Pan Y Successful" } },
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

        public Dictionary<int, string> SetBus_ColorX(int bus, float value) // Physical Bus Only
        {
            string paramName = $"Bus[{bus}.Color_x";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Color X Successful" } },
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

        public Dictionary<int, string> SetBus_ColorY(int bus, float value) // Physical Bus Only
        {
            string paramName = $"Bus[{bus}.Color_y";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Color Y Successful" } },
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

        public Dictionary<int, string> SetBus_Audibility(int bus, float value) //Voicemeeter 1 only
        {
            string paramName = $"Bus[{bus}.Audibility";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set Pan Y Successful" } },
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

        public Dictionary<int, string> SetBus_EQGain1(int bus, float value) // Virtual Bus Only
        {
            string paramName = $"Bus[{bus}.EQGain1";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set EQ Gain1 Successful" } },
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

        public Dictionary<int, string> SetBus_EQGain2(int bus, float value) // Virtual Bus Only
        {
            string paramName = $"Bus[{bus}.EQGain2";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set EQ Gain 2 Successful" } },
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

        public Dictionary<int, string> SetBus_EQGain3(int bus, float value) // Virtual Bus Only
        {
            string paramName = $"Bus[{bus}.EQGain3";

            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, "Set EQ Gain 3 Successful" } },
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
        public Dictionary<int, string> SetPatch_ASIO(int inputChannel, float value)
        {
            string paramName = $"Patch.asio[{inputChannel}]";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set patch ASIO channel {inputChannel} successful" } },
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

        public Dictionary<int, string> SetPatch_Composite(int compositeChannel, float value)
        {
            string paramName = $"Patch.composite[{compositeChannel}]";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set patch composite channel {compositeChannel} successful" } },
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

        public Dictionary<int, string> SetPatch_InsertVirtualASIO(int inputChannel, bool onOff)
        {
            string paramName = $"Patch.insert[{inputChannel}]";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set patch virtual ASIO insert channel {inputChannel} set to {value} successful" } },
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

        public enum VoicemeeterPrePost
        {
            PRE = 0,
            POST = 1
        }

        public Dictionary<int, string> SetPatch_PostFaderComposite(VoicemeeterPrePost value)
        {
            string paramName = $"Patch.PostFaderComposite";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, (float)value) : VBVMR_SetParameterFloat32(paramName, (float)value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set patch Fader Composite to {value} successful" } },
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

        public Dictionary<int, string> SetPatch_PostFXInsert(VoicemeeterPrePost value)
        {
            string paramName = $"Patch.PostFxInsert";
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, (float)value) : VBVMR_SetParameterFloat32(paramName, (float)value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set patch FX Insert to {value} successful" } },
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

        #region System Settings (Option Parameters)

        public Dictionary<int, string> SetOption_PreferredSampleRate(float sampleRate)
        {
            string paramName = $"Option.sr";
            float value = sampleRate;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, (float)value) : VBVMR_SetParameterFloat32(paramName, (float)value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set Option: Preferred Sample Rate to {sampleRate} successful" } },
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

        public Dictionary<int, string> SetOption_ASIOsr(bool preferredSampleRate)
        {
            string paramName = $"Option.sr";
            float value = preferredSampleRate ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, (float)value) : VBVMR_SetParameterFloat32(paramName, (float)value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set ASIO driver on Output A1 to preferred sample rate to {preferredSampleRate} successful" } },
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

        public Dictionary<int, string> SetOption_BufferMME(int bufferSize)
        {
            string paramName = $"Option.buffer.mme";
            float value = (float)bufferSize;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set MME buffer size to {bufferSize} successful" } },
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

        public Dictionary<int, string> SetOption_BufferWDM(int bufferSize)
        {
            string paramName = $"Option.buffer.wdm";
            float value = (float)bufferSize;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set WDM buffer size to {bufferSize} successful" } },
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

        public Dictionary<int, string> SetOption_BufferKS(int bufferSize)
        {
            string paramName = $"Option.buffer.ks";
            float value = (float)bufferSize;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set KS buffer size to {bufferSize} successful" } },
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

        public Dictionary<int, string> SetOption_BufferASIO(int bufferSize)
        {
            string paramName = $"Option.buffer.asio";
            float value = (float)bufferSize;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set ASIO buffer size to {bufferSize} successful" } },
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

        public Dictionary<int, string> SetOption_WDMExclusiveMode(bool onOff)
        {
            string paramName = $"Option.buffer.asio";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);
            string offOn = onOff ? "On" : "Off";

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set WDM Exclusive Mode to {offOn} successful" } },
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

        public Dictionary<int, string> SetOption_WDMSwiftMode(bool onOff)
        {
            string paramName = $"Option.buffer.asio";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);
            string offOn = onOff ? "On" : "Off";

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set WDM Exclusive Mode to {offOn} successful" } },
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

        #region VBAN Parameters

        #region VBAN IN Stream Parameters
        public Dictionary<int, string> EnableVBAN(bool onOff)
        {
            string paramName = $"vban.enable";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Enable VBAN successful" } },
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

        public Dictionary<int, string> SetVBAN_InstreamChannelOn(int instreamChannel, bool onOff)
        {
            string paramName = $"vban.instream[{instreamChannel}].on";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);
            string offOn = onOff ? "On" : "Off";

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set VBAN Instream Channel {instreamChannel} to {offOn} successful" } },
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

        public Dictionary<int, string> SetVBAN_InstreamPort(int instreamChannel, float ethernetPort16Bit)
        {
            string paramName = $"vban.instream[{instreamChannel}].port";
            float value = ethernetPort16Bit;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set VBAN Instream Channel {instreamChannel} to ethernet port {ethernetPort16Bit} successful" } },
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

        public Dictionary<int, string> SetVBAN_InstreamQuality(int instreamChannel, float quality)
        {
            string paramName = $"vban.instream[{instreamChannel}].port";
            float value = quality;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set VBAN Instream Channel {instreamChannel} to quality level {quality} successful" } },
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

        public Dictionary<int, string> SetVBAN_InstreamStripRoute(int instreamChannel, float stripRoute)
        {
            string paramName = $"vban.instream[{instreamChannel}].port";
            float value = stripRoute;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set VBAN Instream Channel {instreamChannel} to Strip[{stripRoute}] successful" } },
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

        #region VBAN OUT Stream Parameters

        public Dictionary<int, string> SetVBAN_OutstreamChannelOn(int outstreamChannel, bool onOff)
        {
            string paramName = $"vban.outstream[{outstreamChannel}].on";
            float value = onOff ? 1f : 0f;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);
            string offOn = onOff ? "On" : "Off";

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set VBAN Outstream Channel {outstreamChannel} to {offOn} successful" } },
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

        public Dictionary<int, string> SetVBAN_OutstreamPort(int outstreamChannel, float ethernetPort16Bit)
        {
            string paramName = $"vban.outstream[{outstreamChannel}].port";
            float value = ethernetPort16Bit;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set VBAN Outstream Channel {outstreamChannel} to ethernet port {ethernetPort16Bit} successful" } },
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

        public Dictionary<int, string> SetVBAN_OutstreamQuality(int outstreamChannel, float quality)
        {
            string paramName = $"vban.outstream[{outstreamChannel}].port";
            float value = quality;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set VBAN Outstream Channel {outstreamChannel} to quality level {quality} successful" } },
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

        public Dictionary<int, string> SetVBAN_OutstreamStripRoute(int outstreamChannel, float stripRoute)
        {
            string paramName = $"vban.outstream[{outstreamChannel}].port";
            float value = stripRoute;
            int result = Is64BitApplicationRunning ? VBVMR_SetParameterFloat64(paramName, value) : VBVMR_SetParameterFloat32(paramName, value);

            Dictionary<int, string> resultMessage = result switch
            {
                0 => new Dictionary<int, string> { { result, $"Set VBAN Outstream Channel {outstreamChannel} to Strip[{stripRoute}] successful" } },
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

        #endregion
    }
}
