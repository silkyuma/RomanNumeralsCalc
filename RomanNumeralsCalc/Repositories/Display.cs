
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsCalc.Repositories
{
    public sealed class Display
    {
        private static Display instance = null;
        private static readonly object padlock = new object();

        Display()
        {
        }
        public static Display Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Display();
                    }
                    return instance;
                }
            }
        }
        public static void DisplayOutput(string output)
        {
            Console.WriteLine(output);

        }
    }
}
