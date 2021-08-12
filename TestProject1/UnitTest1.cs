using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        WebApplication1.ValuesController _controller;

        public UnitTest1()
        {
            _controller = new WebApplication1.ValuesController();
        }
       

        [Fact]
        public void Test1()
        {
            Assert.True(true);

        }

        [Fact]
        public void testPost()
        {
            _controller.Post(1);

            var value = _controller.Get();

            Assert.True(value == 1);
        }
    }
}
