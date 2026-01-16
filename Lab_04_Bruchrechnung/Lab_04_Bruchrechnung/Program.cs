using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Bruchrechnung
{
        class Program
    {
        static void Main(string[] args)
        {
            //Eingabe: 67 / 69 + 38 / 12
            Console.WriteLine("Bitte Bruchrechnung angeben");
            string eingabe = Console.ReadLine();
          Bruchrechnung b =  Bruchrechnung.Parse(eingabe);


            Bruch b1 = Bruch.Parse(eingabe);

            b1.kuerzen();
           
            Console.WriteLine(b.Getresult());
 


            Console.ReadKey();
        }
    }
}
