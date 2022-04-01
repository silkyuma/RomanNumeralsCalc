using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCalc.Repositories
{
    public sealed class ChoiceRoman
    {
        private static ChoiceRoman instance = null;
        private static readonly object padlock = new object();

        ChoiceRoman()
        {
        }
        public static ChoiceRoman Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ChoiceRoman();
                    }
                    return instance;
                }
            }
        }
        public static void GenerateRomanNumeral()
        {
            string romInput, romInput2;



            string mess = "Please enter two Roman Numerals";
            Display.DisplayOutput(mess);
            romInput = GetInput.GetInputFromUser();
            romInput2 = GetInput.GetInputFromUser();
            CheckValidation(romInput, romInput2);




        }
        public static void CheckValidation(string romInput, string romInput2)
        {
            if ((romInput.ToUpper().Equals("MMMCMXCIX")) || (romInput2.ToUpper().Equals("MMMCMXCIX")))
            {
                string mess = "Please enter numeral under MMMCMXCIX";
                Display.DisplayOutput(mess);
                romInput = GetInput.GetInputFromUser();
                romInput2 = GetInput.GetInputFromUser();
                CheckValidation(romInput, romInput2);
            }
            else
            {
                CallRomanToNumberCalc(romInput, romInput2);
            }
        }
        public static void CallRomanToNumberCalc(string romInput, string romInput2)
        {
            int decInput1 = 0;
            int decInput2 = 0;
            decInput1 = RomanNumeralsToNumberCalculator.RomanToDecimal(romInput.ToUpper());
            decInput2 = RomanNumeralsToNumberCalculator.RomanToDecimal(romInput2.ToUpper());
            string romanNumeral = AddNumbers.GenerateRomanNumerals(decInput1, decInput2);
            Display.DisplayOutput(romanNumeral);
            Display.DisplayOutput("");
        }
    }
}
