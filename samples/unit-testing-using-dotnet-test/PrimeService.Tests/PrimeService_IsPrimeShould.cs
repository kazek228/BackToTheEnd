using Xunit;
using Prime.Services;
using NuGet.Frameworks;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        #region Sample Test Code
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        #endregion

        #region
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");

        }
        #endregion

        #region
        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        public void IsPrime_NonPrimesLessThan10_ReturnFalse(int value)
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        #endregion

        #region
        [Theory]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(29)]
        [InlineData(71)]
        public void IsPrime_Prime_BiggerThen10_ReturnTrue(int value)
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");

        }
        #endregion

        #region
        [Theory]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(21)]
        [InlineData(25)]
        [InlineData(98)]
        public void IsPrime_IsNotPrime_BiggerThen10_False(int value)
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
            
        #endregion
    }
}
