using System;

namespace LuhnCsharpImplementation
{
    public static class LuhnAlgorithm
    {
        public static bool IsValid(String number)
        {
            number = number.Replace(" ", "");

            if (number.Length <= 1 || !IsAllDigits(number))
            {
                return false;
            }

            int sum = 0;
            bool shouldDouble = false;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                if (shouldDouble)
                {
                    digit *= 2;

                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                shouldDouble = !shouldDouble;
            }

            return sum % 10 == 0;
        }

        private static bool IsAllDigits(string number)
        {
            foreach (char c in number)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
