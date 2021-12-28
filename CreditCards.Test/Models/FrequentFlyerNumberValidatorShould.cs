using SampleUntiTestingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CreditCards.Test.Models
{
    public class FrequentFlyerNumberValidatorShould
    {
        [Fact]
        public void AcceptValidSchemes()
        {
            var sut = new FrequentFlyerNumberValidator();
            Assert.True(sut.IsValid("123456-A"));
        }
    }
}
