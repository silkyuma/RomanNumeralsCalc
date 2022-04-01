using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCalc.Repositories
{
    public sealed class RomanNumeralsToNumberCalculator
    {
        private static RomanNumeralsToNumberCalculator instance = null;
        private static readonly object padlock = new object();

        RomanNumeralsToNumberCalculator()
        {
        }
        public static RomanNumeralsToNumberCalculator Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RomanNumeralsToNumberCalculator();
                    }
                    return instance;
                }
            }
        }
        public static int RomanToDecimal(string romanNum)
        {
            int number = 0;
            char[] symbols = romanNum.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                int value1 = GetRomanValue(symbols[i]);
                if (i + 1 < symbols.Length)
                {
                    int value2 = GetRomanValue(symbols[i + 1]);
                    if (value1 >= value2)
                    {
                        number = number + value1;
                    }
                    else
                    {
                        number = number + value2 - value1;
                        i++;
                    }
                }
                else
                {
                    number = number + value1;
                }
            }
            return number;
        }
        public static int GetRomanValue(char symbol)
        {
            List<KeyValuePair<char, int>> symbolValue = new List<KeyValuePair<char, int>>
           {
               new KeyValuePair<char,int>('I',1),
               new KeyValuePair<char,int>('V',5),
               new KeyValuePair<char,int>('X',10),
               new KeyValuePair<char,int>('L',50),
               new KeyValuePair<char,int>('C',100),
               new KeyValuePair<char,int>('D',500),
               new KeyValuePair<char,int>('M',1000)
           };
            return symbolValue.SingleOrDefault(u => u.Key == symbol).Value;
        }
    }
}
