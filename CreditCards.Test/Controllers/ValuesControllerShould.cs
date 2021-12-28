using SampleUntiTestingApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CreditCards.Test.Controllers
{
    public class ValuesControllerShould
    {
        [Fact]
        public void ReturnValue()
        {
            var sut = new ValuesController();
            string[] result = sut.Get().ToArray();

            Assert.Equal(2, result.Length);
            Assert.Equal("value1", result[0]);
            Assert.Equal("value2", result[1]);
        }
    }
}
