using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEJM.StringManipulator.UnitTest.AppxUnit
{
    public class StringManipulatorTests
    {
        private readonly StringManipulator manipulator = new StringManipulator();

        [Fact]
        public void ReverseString_InputHola_ReturnsAloh()
        {
            string result = manipulator.ReverseString("Hola");
            Assert.Equal("aloH", result);
        }

        [Fact]
        public void ReverseString_EmptyString_ReturnsEmpty()
        {
            string result = manipulator.ReverseString("");
            Assert.Equal("", result);
        }

        [Fact]
        public void RemoveSpaces_InputWithSpaces_ReturnsWithoutSpaces()
        {
            string result = manipulator.RemoveSpaces("H o l a");
            Assert.Equal("Hola", result);
        }

        [Fact]
        public void RemoveSpaces_InputWithoutSpaces_ReturnsSame()
        {
            string result = manipulator.RemoveSpaces("Hola");
            Assert.Equal("Hola", result);
        }
    }
}
