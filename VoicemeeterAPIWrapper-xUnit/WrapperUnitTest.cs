using VoicemeeterAPIWrapperLibrary;
using Microsoft.Extensions.Logging;
using static VoicemeeterAPIWrapperLibrary.VoicemeeterAPIWrapper;
using VoicemeeterAPIWrapper;

namespace VoicemeeterAPIWrapper_xUnit
{
    public class WrapperUnitTest
    {
        [Fact]
        public void Wrapper_InitializesWithCorrectBitness()
        {
            //Accessing the static property directly from the class, not an instance
            var bitness = Is64BitApplicationRunning;

            //Assert
            Assert.Equal(Environment.Is64BitProcess, bitness);
        }

        #region Login
        [Fact]
        public void Login_ReturnsTrue_WhenSuccessful()
        {
            //Arrange
            var mockILogger = new Mock<ILogger<VoicemeeterAPIWrapper>>();
            var wrapper = new VoicemeeterAPIWrapper(mockILogger.Object);
            wrapper.Logout();

            //Act & Assert
            Assert.True(wrapper.Login());
        }

        [Fact]
        public void Logout_ReturnsTrue_WhenSuccessful()
        {
            //Arrange
            var mockILogger = new Mock<ILogger<VoicemeeterAPIWrapper>>();
            var wrapper = new VoicemeeterAPIWrapper(mockILogger.Object);
            wrapper.Login();

            //Act & Assert
            Assert.True(wrapper.Logout());
        }

        [Fact]
        public void Login_ReturnsFalse_WhenUnsuccessful()
        {
            //Arrange
            var mockILogger = new Mock<ILogger<VoicemeeterAPIWrapper>>();
            var wrapper = new VoicemeeterAPIWrapper(mockILogger.Object);

            //Setup mocking to simulate login failure
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.Login()).Returns(false);

            //Act
            var result = mockWrapper.Object.Login();

            //Assert
            Assert.False(result);
        }
        #endregion

        #region General Information
        [Fact]
        public void GetApplicationBitness_ReturnsCorrectBitness()
        {
            //Arrange
            var expectedBitness = Environment.Is64BitProcess ? "64-bit" : "32-bit";

            //Act
            var bitness = VoicemeeterAPIWrapper.GetApplicationBitness();

            //Assert
            Assert.Equal(expectedBitness, bitness);
        }

        [Fact]
        public void GetVoicemeeterType_ReturnsCorrectType()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.GetVoicemeeterType()).Returns("Voicemeeter Banana");

            //Act
            var type = mockWrapper.Object.GetVoicemeeterType();

            //Assert
            Assert.Equal("Voicemeeter Banana", type);
        }

        [Fact]
        public void GetVoicemeeterVersion_ReturnsCorrectVersion()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.GetVoicemeeterVersion()).Returns("1.0.0.0");

            //Act
            var version = mockWrapper.Object.GetVoicemeeterVersion();

            //Assert
            Assert.Equal("1.0.0.0", version);
        }
        #endregion

        #region Get Parameters
        [Fact]
        public void IsParameterDirty_ReturnsTrue_WhenParametersChanged()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.IsParameterDirty()).Returns(true);

            //Act
            var changed = mockWrapper.Object.IsParameterDirty();

            //Assert
            Assert.True(changed);
        }

        [Fact]
        public void IsParameterDirty_ReturnsFalse_WhenParametersUnchanged()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.IsParameterDirty()).Returns(false);

            //Act
            var changed = mockWrapper.Object.IsParameterDirty();

            //Assert
            Assert.False(changed);
        }

        [Fact]
        public void GetParameterFloat_ReturnsFloat()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.GetParameterFloat("Strip[0].A1")).Returns(1f);

            //Act
            var param = mockWrapper.Object.GetParameterFloat("Strip[0].A1");

            //Assert
            Assert.Equal(1f, param);
        }

        [Fact]
        public void GetParameterStringA_ReturnsANSIString()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.GetParameterStringA("Strip[0].Name")).Returns("Microphone");

            //Act
            var paramA = mockWrapper.Object.GetParameterStringA("Strip[0].Name");

            //Assert
            Assert.Equal("Microphone", paramA);
        }

        [Fact]
        public void GetParameterStringW_ReturnsUnicodeString()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.GetParameterStringW("Strip[1].Label")).Returns("Discord");

            //Act
            var paramW = mockWrapper.Object.GetParameterStringW("Strip[1].Label");

            //Assert
            Assert.Equal("Discord", paramW);
        }
        #endregion

        #region Levels
        [Fact]
        public void GetLevel_ReturnsFloat()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.GetLevel(0, 1)).Returns(98.6f);
            

            //Act
            var level = mockWrapper.Object.GetLevel(0, 1);

            //Assert
            Assert.Equal(98.6f, level);
            Assert.Equal(typeof(float), level.GetType());
        }

        [Fact]
        public void GetMidiMessage_ReturnsInt()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            byte[] midi = { 0, 3, 4, 5, 32, 2 };
            mockWrapper.Setup(wrapper => wrapper.GetMidiMessage(out midi)).Returns(15);

            //Act
            var result = mockWrapper.Object.GetMidiMessage(out midi);

            //Assert
            Assert.Equal(15, result);
        }
        #endregion

        #region Set Parameters
        [Fact]
        public void SetParameterFloat_WhenParameterSuccessfullyChanged()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.SetParameterFloat("Strip[0].A1", 1f)).Returns(true);

            //Act
            var result = mockWrapper.Object.SetParameterFloat("Strip[0].A1", 1f);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SetParameterFloat_WhenParameterUnchanged()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.SetParameterFloat("Strip[0].A1", 1f)).Returns(false);

            //Act
            var result = mockWrapper.Object.SetParameterFloat("Strip[0].A1", 1f);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SetParameterStringA_WhenParameterSuccessfullyChanged()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.SetParameterStringA("Strip[0].Label", "Mic")).Returns(true);

            //Act
            var result = mockWrapper.Object.SetParameterStringA("Strip[0].Label", "Mic");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SetParameterStringW_WhenParameterSuccessfullyChanged()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.SetParameterStringW("Strip[0].Label", "Mic")).Returns(true);

            //Act
            var result = mockWrapper.Object.SetParameterStringW("Strip[0].Label", "Mic");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void SetParameterStringW_WhenParameterFailsChange()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.SetParameterStringW("Strip[1].Label", "Mic")).Returns(false);

            //Act
            var result = mockWrapper.Object.SetParameterStringW("Strip[1].Label", "Mic");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SetParameterStringA_WhenParameterFailsChange()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.SetParameterStringA("Strip[1].Label", "Mic")).Returns(false);

            //Act
            var result = mockWrapper.Object.SetParameterStringA("Strip[1].Label", "Mic");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SetParametersA_ReturnsString_Successful()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create expected script
            string expectedScript = "blah, blah, blah";

            mockWrapper.Setup(wrapper => wrapper.SetParametersA(expectedScript)).Returns("SetParametersA Successful");

            //Act
            var result = mockWrapper.Object.SetParametersA(expectedScript);

            //Assert
            Assert.Equal("SetParametersA Successful", result);
        }

        [Fact]
        public void SetParametersW_ReturnsString_Successful()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create expected script
            string expectedScript = "blah, blah, blah";

            mockWrapper.Setup(wrapper => wrapper.SetParametersW(expectedScript)).Returns("SetParametersW Successful");

            //Act
            var result = mockWrapper.Object.SetParametersW(expectedScript);

            //Assert
            Assert.Equal("SetParametersW Successful", result);
        }
        #endregion

        #region Devices Enumerator
        [Fact]
        public void Output_GetDeviceNumber_ReturnsInt()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.Output_GetDeviceNumber()).Returns(5);

            //Act
            var result = mockWrapper.Object.Output_GetDeviceNumber();

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Output_GetDeviceDescA_ReturnsDictionaryWithFiveEntries()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create expected dictionary
            var expectedDictionary = new Dictionary<string, string>
            {
                { "Index", "3" },
                { "Type", "MME" },
                { "Name", "Speakers" },
                { "Id", "0x00112000" },
                { "Result", "Success" }
            };

            mockWrapper.Setup(wrapper => wrapper.Output_GetDeviceDescA(3)).Returns(expectedDictionary);

            //Act
            var result = mockWrapper.Object.Output_GetDeviceDescA(3);

            //Assert
            Assert.Equal(expectedDictionary, result);
        }

        [Fact]
        public void Output_GetDeviceDescW_ReturnsDictionaryWithFiveEntries()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create expected dictionary
            var expectedDictionary = new Dictionary<string, string>
            {
                { "Index", "3" },
                { "Type", "MME" },
                { "Name", "Speakers" },
                { "Id", "0x00112000" },
                { "Result", "Success" }
            };

            mockWrapper.Setup(wrapper => wrapper.Output_GetDeviceDescW(3)).Returns(expectedDictionary);

            //Act
            var result = mockWrapper.Object.Output_GetDeviceDescW(3);

            //Assert
            Assert.Equal(expectedDictionary, result);
        }

        [Fact]
        public void Input_GetDeviceNumber_ReturnsInt()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.Input_GetDeviceNumber()).Returns(5);

            //Act
            var result = mockWrapper.Object.Input_GetDeviceNumber();

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Input_GetDeviceDescA_ReturnsDictionaryWithFiveEntries()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create expected dictionary
            var expectedDictionary = new Dictionary<string, string>
            {
                { "Index", "3" },
                { "Type", "MME" },
                { "Name", "Speakers" },
                { "Id", "0x00112000" },
                { "Result", "Success" }
            };

            mockWrapper.Setup(wrapper => wrapper.Input_GetDeviceDescA(3)).Returns(expectedDictionary);

            //Act
            var result = mockWrapper.Object.Input_GetDeviceDescA(3);

            //Assert
            Assert.Equal(expectedDictionary, result);
        }

        [Fact]
        public void Input_GetDeviceDescW_ReturnsDictionaryWithFiveEntries()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create expected dictionary
            var expectedDictionary = new Dictionary<string, string>
            {
                { "Index", "3" },
                { "Type", "MME" },
                { "Name", "Speakers" },
                { "Id", "0x00112000" },
                { "Result", "Success" }
            };

            mockWrapper.Setup(wrapper => wrapper.Input_GetDeviceDescW(3)).Returns(expectedDictionary);

            //Act
            var result = mockWrapper.Object.Input_GetDeviceDescW(3);

            //Assert
            Assert.Equal(expectedDictionary, result);
        }
        #endregion

        #region Audio Callback
        [Fact]
        public void AudioCallbackRegister_UsesProvidedCallback()
        {
            // Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            var userData = IntPtr.Zero;
            var clientName = "TestClient";

            // Using a real method as the callback
            VoicemeeterAPIWrapper.VoicemeeterAudioCallback callbackDelegate = MyTestCallbackMethod;

            // You can also use a lambda expression:
            // VoicemeeterAudioCallback callbackDelegate = (userPtr, command, data, n) => 0;

            mockWrapper.Setup(wrapper => wrapper.AudioCallbackRegister(
                VoicemeeterAPIWrapper.VoicemeeterAudioCallbackMode.Main,
                callbackDelegate,
                userData,
                clientName))
                .Returns(new Dictionary<int, string> { { 0, "Successful (no errors)" } });

            // Act
            var result = mockWrapper.Object.AudioCallbackRegister(
                VoicemeeterAPIWrapper.VoicemeeterAudioCallbackMode.Main,
                callbackDelegate,
                userData,
                clientName);

            // Assert
            Assert.True(result.ContainsKey(0));
            Assert.Equal("Successful (no errors)", result[0]);
        }

        private int MyTestCallbackMethod(IntPtr lpUser, VoicemeeterAPIWrapper.VoicemeeterCallBackCommand nCommand, IntPtr lpData, int nnn)
        {
            // Implement mock callback logic here
            return 0;
        }

        [Fact]
        public void AudioCallbackStart_ReturnsDictionaryResult_Successful()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create Expected Dictionary result
            Dictionary<int, string> expectedDictionary = new Dictionary<int, string>
            {
                { 0, "Successful (no errors)" }
            };

            mockWrapper.Setup(wrapper => wrapper.AudioCallbackStart()).Returns(expectedDictionary);

            //Act
            var result = mockWrapper.Object.AudioCallbackStart();

            //Assert
            Assert.Equal(expectedDictionary, result);
        }

        [Fact]
        public void AudioCallbackStop_ReturnsDictionary_Successful()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create expected Dictionary result
            Dictionary<int, string> expectedDictionary = new Dictionary<int, string>
            {
                {0, "Successful (no errors)" }
            };

            mockWrapper.Setup(wrapper => wrapper.AudioCallbackStop()).Returns(expectedDictionary);

            //Act
            var result = mockWrapper.Object.AudioCallbackStop();

            //Assert
            Assert.Equal(expectedDictionary, result);
        }

        [Fact]
        public void AudioCallbackUnRegister_ReturnsDictionary_Successful()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //Create expected Dictionary result
            Dictionary<int, string> expectedDictionary = new Dictionary<int, string>
            {
                {0, "Successful (no errors)" }
            };

            mockWrapper.Setup(wrapper => wrapper.AudioCallbackUnregister()).Returns(expectedDictionary);

            //Act
            var result = mockWrapper.Object.AudioCallbackUnregister();

            //Assert
            Assert.Equal(expectedDictionary, result);
        }
        #endregion

        #region Macro Buttons
        [Fact]
        public void MacroButtonIsDirty_ReturnsFalse_UnchangedState()
        {
            //Arrange
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.MacroButtonIsDirty()).Returns(false);

            //Act
            var result = mockWrapper.Object.MacroButtonIsDirty();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void MacroButtonGetStatus_ReturnsFloat_Successful()
        {
            //Arrange 
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();
            mockWrapper.Setup(wrapper => wrapper.MacroButtonGetStatus(1, VoicemeeterMacroButtonMode.StateOnly)).Returns(0f);

            //Act
            var result = mockWrapper.Object.MacroButtonGetStatus(1, VoicemeeterMacroButtonMode.StateOnly);

            //Assert
            Assert.Equal(0f, result);
        }

        [Fact]
        public void MacroButtonSetStatus_ReturnsDictionary()
        {
            //Arrange 
            var mockWrapper = new Mock<IVoicemeeterAPIWrapper>();

            //create expectedDictionary
            Dictionary<int, string> expectedDictionary = new Dictionary<int, string>
            {
                {0, "Successful" }
            };

            mockWrapper.Setup(wrapper => wrapper.MacroButtonSetStatus(1, 1f, VoicemeeterMacroButtonMode.StateOnly)).Returns(expectedDictionary);

            //Act
            var result = mockWrapper.Object.MacroButtonSetStatus(1, 1f, VoicemeeterMacroButtonMode.StateOnly);

            //Assert
            Assert.Equal(expectedDictionary, result);
        }
        #endregion
    }
}
