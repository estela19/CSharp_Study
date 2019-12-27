using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    class AlphabetPramid
    {
        static void Main(string[] args)
        {
            Console.Write("Input string : ");
            string str = Console.ReadLine();

            for(int i = 1; i <= str.Length; i++)
            {
                Console.WriteLine(str.Substring(0, i));
            }
            Console.ReadLine();
        }
    }
}
