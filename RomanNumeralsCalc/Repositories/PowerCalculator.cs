namespace RomanNumeralsCalc.Repositories
{

    public class PowerCalculator
    {
        private static PowerCalculator instance = null;
        private static readonly object padlock = new object();

        PowerCalculator()
        {
        }
        public static PowerCalculator Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PowerCalculator();
                    }
                    return instance;
                }
            }
        }
        public static bool IsValuePowerOfTen(int value)
        {
            return IsValuePowerOfX(10, value);
        }

        private static bool IsValuePowerOfX(int x, int value)
        {
            while (value > x - 1 && value % x == 0)
            {
                value /= x;
            }
            return value == 1;
        }
    }
}
