using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCalc.Repositories
{
    public sealed class AddNumbers
    {
        private static AddNumbers instance = null;
        private static readonly object padlock = new object();

        AddNumbers()
        {
        }
        public static AddNumbers Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new AddNumbers();
                    }
                    return instance;
                }
            }
        }
        public static string GenerateRomanNumerals(int decInput1, int decInput2)
        {
            int result = 0;
            result = decInput1 + decInput2;
            string romanNumeral = NumberToRomanNumeralsCalculator.CalculateRomanNumeral(result);

            return romanNumeral;
        }
    }
}
