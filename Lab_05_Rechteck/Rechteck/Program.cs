using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die höhe des Rechtecks ein:");
            float hoehe = float.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie die Breite des Rechtecks ein:");
            float breite = float.Parse(Console.ReadLine());

            ConsoleKeyInfo key = Console.ReadKey(true);

            int cntright = 0;

            int cntdown = 0;
            while (key.Key == ConsoleKey.RightArrow|| key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {

                key = Console.ReadKey(true);
                Console.Clear();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    cntright++;

                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    cntright--;

                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    cntdown--;
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    cntdown++;
                }

                for(int i = 0; i < cntdown; i++)
                {
                    if(cntdown>0)
                    {Console.WriteLine(); }
                    
                }
                for(int i =0;i<cntright;i++)
                {
                    if(cntright>0)
                    { Console.Write(" "); }
                }
                for (int i = 0; i < breite; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int i=0;i<hoehe-2;i++)
                {
                    for (int j = 0; j < cntright; j++)
                    {
                        if (cntright > 0)
                        { Console.Write(" "); }
                    }
                    Console.Write("*");
                    for (int l = 0; l < breite - 2; l++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                for (int i = 0; i < cntright; i++)
                {
                    if (cntright > 0)
                    { Console.Write(" "); }
                }
                for (int i = 0; i < breite; i++)
                {
                    Console.Write("*");
                }
            }

            Console.ReadKey();
        }
    }
}
