using RomanNumbersConverter;

namespace RomanNumbers.IntegrationTest
{
    public class Tests
    {
        [Test]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("iV", 4)]
        [TestCase("v", 5)]
        [TestCase("IX", 9)]
        [TestCase("XlII", 42)]
        [TestCase("XCiX", 99)]
        [TestCase("MMXIII", 2013)]
        public void ConvertBackwords_InputCorrectString_ReturnCorrectValues(string romanNumber, int integer)
        {
            var result = RomanNumberConverter.ConvertBackwords(romanNumber);

            Assert.That(result, Is.EqualTo(integer));
        }
    }
}