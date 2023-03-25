using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.otherSrc
{
    internal class StarDiamond
    {
        public void run()
        {
            int lineNums = int.Parse(Console.ReadLine() ?? "");

            for (int i = 0; i < lineNums; i++)
            {
                for (int j = 1; j < lineNums - i; j++)
                {
                    Console.Write("_");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = lineNums - 2; i >= 0; i--)
            {
                for (int j = 1; j < lineNums - i; j++)
                {
                    Console.Write("_");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
