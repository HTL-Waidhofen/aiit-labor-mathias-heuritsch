using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Bruchrechnung
{
     class Bruchrechnung
    {
        Bruch b1;
        Bruch b2;
        
        public static Bruchrechnung Parse( string eingabe)
        {
            string[] teile = eingabe.Split('-', '+', '*', ':');
            Bruchrechnung br = new Bruchrechnung();
            br.b1 = Bruch.Parse(teile[0]);
            br.b2 = Bruch.Parse(teile[1]);
            return br;
        }

        public Bruch Getresult()
        {

        }
    }
}
