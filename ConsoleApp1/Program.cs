using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CompareVersions("4.5.3", "4.5.6.6"));
            Console.WriteLine(CompareVersions("1.0.0", "1.0"));
            Console.WriteLine(CompareVersions("1.1.0", "1.0.1"));

            Console.ReadLine();
        }

        private static int CompareVersions(String first, String second)
        {
            String[] firstArray = first.Split('.');
            String[] secondArray = second.Split('.');

            String[] longest = firstArray.Length >= secondArray.Length ? firstArray : secondArray;

            for (int i = 0; i < longest.Length; i++)
            {
                int fDigit = Int32.Parse(firstArray.Length > i ? firstArray[i] : "0");
                int sDigit = Int32.Parse(secondArray.Length > i ? secondArray[i] : "0");

                if (fDigit > sDigit) return 1;
                if (fDigit < sDigit) return -1;
            }

            return 0;
        }
    }
}
