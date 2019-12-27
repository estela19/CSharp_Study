using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    class Star
    {
        static void Main(string[] args)
        {
            Console.Write("Input Num : ");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            string tmp = Console.ReadLine();
        }
    }
}
