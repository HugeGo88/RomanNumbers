using RomanNumbersConverter;

namespace RomanNumbers.IntegrationTest
{
    public class Tests
    {
        [Test]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("IX", 9)]
        [TestCase("XLII", 42)]
        [TestCase("XCIX", 99)]
        [TestCase("MMXIII", 2013)]
        public void ConvertBackwords_InputCorrectString_ReturnCorrectValues(string romanNumber, int integer)
        {
            var result = RomanNumberConverter.ConvertBackwords(romanNumber);

            Assert.That(result, Is.EqualTo(integer));
        }
    }
}