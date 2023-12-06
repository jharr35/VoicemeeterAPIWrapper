using Microsoft.Extensions.Logging;

namespace VoicemeeterAPIWrapperLibrary
{
    public partial class VoicemeeterAPIWrapper
    {
        //These methods will allow the user to easily access the Voicemeeter API to set parameters

        public Dictionary<int, string> SetGain(int strip, float value)
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

        public Dictionary<int, string> SetA1(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.A1";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetA2(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.A2";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetA3(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.A3";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetA4(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.A4";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetA5(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.A5";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetB1(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.B1";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetB2(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.B2";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetB3(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.B3";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetMono(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.Mono";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetMute(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.Mute";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetSolo(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.Solo";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetMC(int strip, bool flag)
        {
            string paramName = $"Strip[{strip}.MC";
            float value = flag ? 1f : 0f;
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

        public Dictionary<int, string> SetPanX(int strip, float value)
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

        public Dictionary<int, string> SetPanY(int strip, float value)
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

        public Dictionary<int, string> SetColorX(int strip, float value) // Physical Strip Only
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

        public Dictionary<int, string> SetColorY(int strip, float value) // Physical Strip Only
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

        public Dictionary<int, string> SetAudibility(int strip, float value) //Voicemeeter 1 only
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

        public Dictionary<int, string> SetEQGain1(int strip, float value) // Virtual Strip Only
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

        public Dictionary<int, string> SetEQGain2(int strip, float value) // Virtual Strip Only
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

        public Dictionary<int, string> SetEQGain3(int strip, float value) // Virtual Strip Only
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
    }
}
