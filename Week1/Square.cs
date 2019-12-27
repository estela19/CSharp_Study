using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    class Square
    {
        static void Main(string[] args)
        {
            Console.Write("Input width : ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input height : ");
            int height = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < height; i++)
            {
                if(i == 0 || i == height - 1)
                {
                    for(int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                }

                else
                {
                    for(int j = 0; j < width; j++)
                    {
                        if(j == 0 || j == width - 1)
                        {
                            Console.Write("*");
                        }

                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
