using System;
using System.Collections.Specialized;
using System.Text;

namespace RomanNumeralsCalc.Repositories
{
    public sealed class NumberToRomanNumeralsCalculator
    {
        private static NumberToRomanNumeralsCalculator instance = null;
        private static readonly object padlock = new object();

        NumberToRomanNumeralsCalculator()
        {
        }
        public static NumberToRomanNumeralsCalculator Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new NumberToRomanNumeralsCalculator();
                    }
                    return instance;
                }
            }
        }
        private static readonly OrderedDictionary RomanNumerals = new OrderedDictionary()
        {
            {"I", 1}, {"V", 5}, {"X", 10}, {"L", 50}, {"C", 100}, {"D", 500}, {"M", 1000}
        };

        public static string CalculateRomanNumeral(int currentInput)
        {
            string answer = "";

            if (ValidateInput.IsInputValid(currentInput))
            {
                if (IsInputRomanNumerals(currentInput))
                {
                    string romanNumeral = GetRomanNumeralFromValue(currentInput);
                    return romanNumeral;
                }
                int nextInput;
                if (IsInputLarger(currentInput))
                {
                    int largestValue = LargestRomanNumerals();
                    string largestRomanNumeral = GetRomanNumeralFromValue(largestValue);
                    answer += largestRomanNumeral;
                    nextInput = currentInput - largestValue;
                }
                else
                {
                    int lowerRomanNumeralValue = GetLowerRomanNumeralValue(currentInput);
                    int upperRomanNumeralValue = GetUpperRomanNumeralValue(lowerRomanNumeralValue);
                    int upperRomanNumeralValueMinusInput = upperRomanNumeralValue - currentInput;
                    int lowerPowerOfTenRomanNumeralValue = GetLowerPowerOfValue(lowerRomanNumeralValue, upperRomanNumeralValue);

                    if (CanSmallerNumeralInFrontOfLargerNumeral(upperRomanNumeralValueMinusInput, lowerPowerOfTenRomanNumeralValue))
                    {
                        string lowerPowerOfTenInFrontOfUpperRoman = ConcatenateFromValues(lowerPowerOfTenRomanNumeralValue, upperRomanNumeralValue);
                        int lowerPowerOfTenInFrontOfUpperRomanValue = upperRomanNumeralValue - lowerPowerOfTenRomanNumeralValue;
                        answer += lowerPowerOfTenInFrontOfUpperRoman;
                        nextInput = currentInput - lowerPowerOfTenInFrontOfUpperRomanValue;
                    }
                    else
                    {
                        answer += GetRomanNumeralFromValue(lowerRomanNumeralValue);
                        nextInput = currentInput - lowerRomanNumeralValue;
                    }
                }
                answer += CalculateRomanNumeral(nextInput);
            }
            return answer;
        }

        private static bool CanSmallerNumeralInFrontOfLargerNumeral(int upperValueMinusInput, int lowerPowerOfTenValue)
        {
            return upperValueMinusInput <= lowerPowerOfTenValue;
        }

        private static bool IsInputRomanNumerals(int currentInput)
        {
            return RomanNumerals.ContainsValue(currentInput);
        }

        private static bool IsInputLarger(int input)
        {
            return input > LargestRomanNumerals();
        }

        private static int LargestRomanNumerals()
        {
            return GetIndexRomanNumeralValue(RomanNumerals.Count - 1);
        }

        private static int GetLowerPowerOfValue(int lowerValue, int upperValue)
        {
            int lowerPowerOfTen= lowerValue;

            if (PowerCalculator.IsValuePowerOfTen(upperValue))
            {
                lowerPowerOfTen = GetNextLowerPowerOfTen(lowerValue);
            }
            return lowerPowerOfTen;
        }

        private static string ConcatenateFromValues(int beforeRomanNumeralValue, int afterRomanNumeralValue)
        {
            
            string lowerRomanNumeralPowerOfTen = GetRomanNumeralFromValue(beforeRomanNumeralValue);
            string upperRomanNumeral = GetRomanNumeralFromValue(afterRomanNumeralValue);
           
            return lowerRomanNumeralPowerOfTen + upperRomanNumeral;
        }

        private static int GetNextLowerPowerOfTen(int currentValue)
        {
            int lowerPowerValue = 0;
            if (PowerCalculator.IsValuePowerOfTen(currentValue))
            {
                lowerPowerValue = currentValue;
            }
            else
            {
                int lowerRomanIndex = RomanNumerals.IndexOfValue(currentValue);
                for (int i = lowerRomanIndex; i >= 0; i--)
                {
                    int currentNumeralValue = GetIndexRomanNumeralValue(i);
                    if (PowerCalculator.IsValuePowerOfTen(currentNumeralValue))
                    {
                        lowerPowerValue = currentNumeralValue;
                        break;
                    }
                }
            }
            return lowerPowerValue;
        }

        private static int GetUpperRomanNumeralValue(int lowerRomanNum)
        {
            int index = RomanNumerals.IndexOfValue(lowerRomanNum);
            int upperRomanNum = GetIndexRomanNumeralValue(index + 1);
            return upperRomanNum;
        }

        private static int GetLowerRomanNumeralValue(int input)
        {
            for (int i = RomanNumerals.Count - 1; i >= 0; i--)
            {
                int romanNumeralValue = GetIndexRomanNumeralValue(i);

                if (romanNumeralValue <= input)
                {
                    return romanNumeralValue;
                }
            }
            throw new Exception();
        }

        private static int GetIndexRomanNumeralValue(int index)
        {
            return (int)RomanNumerals[index];
        }

        private static string GetRomanNumeralFromValue(int value)
        {
            return (string)RomanNumerals.GetKeyFromFirstElementWithValue(value);
        }
    }
}


