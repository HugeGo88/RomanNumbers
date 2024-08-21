using RomanNumbersConverter;

namespace RomanNumbers.UnitTest
{
    public class Tests
    {

        [Test]
        [TestCase("I", new int[] { 1 })]
        [TestCase("II", new int[] { 1, 1 })]
        [TestCase("IV", new int[] { 1, 5 })]
        [TestCase("V", new int[] { 5 })]
        [TestCase("IX", new int[] { 1, 10 })]
        [TestCase("XLII", new int[] { 10, 50, 1, 1 })]
        [TestCase("XCIX", new int[] { 10, 100, 1, 10 })]
        [TestCase("MMXIII", new int[] { 1000, 1000, 10, 1, 1, 1 })]
        public void ConvertStringToValues_AddStrings_ReturnCorrectValues(string romanNumber, int[] values)
        {
            var result = RomanNumberConverter.ConvertStringToValues(romanNumber);

            Assert.That(values, Is.EqualTo(result));
        }
    }
}