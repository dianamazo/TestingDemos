using Prime.Service;

using System;

using Xunit;

namespace xUnitTest.Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        readonly PrimeService _primeService;
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }


        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {           
            bool result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }


        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }
}
