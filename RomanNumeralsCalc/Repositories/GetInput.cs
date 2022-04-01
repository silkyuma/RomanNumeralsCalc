
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCalc.Repositories
{
    public sealed class GetInput
    {
        private static GetInput instance = null;
        private static readonly object padlock = new object();

        GetInput()
        {
        }
        public static GetInput Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new GetInput();
                    }
                    return instance;
                }
            }
        }
        public static string GetInputFromUser()
        {
           return Console.ReadLine();
        }
    }
}
