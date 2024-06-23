using StringManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var resut = strOperations.ConcatenateStrings("Hello","Alfonso");
            
            //Assert
            Assert.NotEmpty(resut);
            Assert.NotNull(resut);
            Assert.Equal("Hello Alfonso", resut);

        }
        [Fact]
        public void IsPalindrome_True()
        {
            var strOperations = new StringOperations();

            var result = strOperations.IsPalindrome("ana");

            Assert.True(result);
        }
        [Fact]
        public void IsPalindrome_False()
        {
            var strOperations = new StringOperations();

            var result = strOperations.IsPalindrome("hello");

            Assert.False(result);
        }
    }
}
