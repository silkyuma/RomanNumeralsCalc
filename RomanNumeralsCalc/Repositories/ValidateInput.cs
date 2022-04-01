namespace RomanNumeralsCalc.Repositories
{
    public class ValidateInput
    {
        public static bool IsInputValid(int currentInput)
        {
            return currentInput >= Constants.MinimumValueComputable && currentInput <= Constants.MaximumValueComputable;
        }
    }
}
