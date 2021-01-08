using System;
using Xunit;
using SimpleAPI.Controllers;



namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnName() 
        {
            var returnValue = controller.Get(1);
            Assert.Equal("steven", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(3,3);
        }
    }
}
