using System;
using Nelibur.ObjectMapper;
using UnitTest.Model;
using Xunit;
using Xunit.Abstractions;


namespace UnitTest.Base
{
    public class TinyMapTest
    {
        private ITestOutputHelper _testOutputHelper;
        public TinyMapTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void TinyMap_null_map()
        {
            MyTaBleEntity myTaBleEntity = null;

            var myTinyMapDto = new MyTinyMapDto
            {
                MyProperty = "1",
                MyProperty2 = 1
            };

            TinyMapper.Map(myTinyMapDto, myTaBleEntity);

            _testOutputHelper.WriteLine("ok");
        }


        [Fact]
        public void Divide_Zero_Exception()
        {
            var number = 0;
            var result = 10 / number;

            _testOutputHelper.WriteLine("ok");
        }
    }

    
}
