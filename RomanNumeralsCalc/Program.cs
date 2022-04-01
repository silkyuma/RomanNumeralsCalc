

namespace RomanNumeralsCalc.Repositories
{
    class Program
    {
        static void Main(string[] args)
        {



            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE"); //Use this to test different languages.
            char ch;

            do
            {
                string introMessage = "Please enter  D for Decimal And R for Roman Numerals";
                Display.DisplayOutput(introMessage);
                

                ch = Convert.ToChar(GetInput.GetInputFromUser());
                switch (ch)
                {
                    case 'r':
                        ChoiceRoman.GenerateRomanNumeral();
                        break;
                    case 'd':
                        ChoiceDecimal.GenerateDecimal();
                        break;
                        default:
                        throw new Exception("You did not enter valid char");

                }
            }while(ch != ' ');
            

        }
    }
}