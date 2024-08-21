

namespace RomanNumbersConverter
{
    public static class RomanNumberConverter
    {

        private static readonly Dictionary<char, int> valueDict = new Dictionary<char, int>() {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int ConvertBackwords(string romanNumber)
        {
            int[] values = ConvertStringToValues(romanNumber);

            int integer = BackwordSum(values);

            return integer;
        }

        private static int BackwordSum(int[] values)
        {
            int result = 0;
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }
            return result;
        }

        public static int[] ConvertStringToValues(string romanNumber)
        {
            string _romanNumber = romanNumber.ToUpper();

            int[] values = new int[_romanNumber.Length];

            for (int i = 0; i < _romanNumber.Length; i++)
            {
                char character = _romanNumber[i];
                valueDict.TryGetValue(character, out values[i]);
            }

            return values;
        }
    }
}
