using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoicemeeterAPIWrapperLibrary;

namespace VoicemeeterAPIWrapper_xUnit
{
    public class WrapperUnitTest_NoMock
    {
        private readonly VoicemeeterAPIWrapper _voicemeeter;

        public WrapperUnitTest_NoMock() 
        {
            var loggerMock = new Mock<ILogger<VoicemeeterAPIWrapper>>();
            _voicemeeter = new VoicemeeterAPIWrapper(loggerMock.Object);
        }

        [Fact]
        public void GetParameterFloat_ReturnGainOfA1()
        {
            var result = _voicemeeter.GetParameterFloat("Strip[0].A1");

            //Assert
            Assert.Equal(0.0f, result);
        }
    }
}
