using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCalc.Repositories
{
    public sealed class ChoiceDecimal
    {
        private static ChoiceDecimal instance = null;
        private static readonly object padlock = new object();
      
        ChoiceDecimal()
        {
        }
        public static ChoiceDecimal Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ChoiceDecimal();
                    }
                    return instance;
                }
            }
        }
        public static void GenerateDecimal()
        {


            int decInput1 = 0;
            int decInput2 = 0;


            string mess = "Please enter two Decimals";
            Display.DisplayOutput(mess);


            decInput1 = Int32.Parse(GetInput.GetInputFromUser());
            decInput2 = Int32.Parse(GetInput.GetInputFromUser());
            CheckValidation(decInput1, decInput2);


        }
        public static void CheckValidation(int decInput1, int decInput2)
        {
            if (((ValidateInput.IsInputValid(decInput1) == false) || (ValidateInput.IsInputValid(decInput2) == false)))
            {
                string mess = "Please enter Decimals between 1-3999";
                Display.DisplayOutput(mess);
                decInput1 = Int32.Parse(GetInput.GetInputFromUser());
                decInput2 = Int32.Parse(GetInput.GetInputFromUser());
                CheckValidation(decInput1, decInput2);
               

            }
            else
            {

                string romanNumeral = AddNumbers.GenerateRomanNumerals(decInput1, decInput2);
                Display.DisplayOutput(romanNumeral);
                Display.DisplayOutput("");
               
            }


        }
       
    }
}

