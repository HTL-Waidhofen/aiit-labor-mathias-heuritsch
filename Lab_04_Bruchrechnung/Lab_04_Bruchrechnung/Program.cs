using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Bruchrechnung
{
    class Bruch
    {
        private int Nenner;
        private int Zaehler;

        public Bruch(int zaehler, int nenner)
        {
            Zaehler = zaehler;
            Nenner = nenner;
        }

        public int getZaehler()
        {
            return Zaehler;
        }
        public override string ToString()
        {
            return Zaehler + "|" + Nenner;
        }
        public int getNenner()
        {
            return Nenner;
        }
        public void Setzaehler(int zaehler)
        {
            Zaehler = zaehler;

        }
        public void Setnenner(int nenner)
        {
            if(nenner ==0) 
            { 
                Console.WriteLine("Nenner darf nicht 0 sein");//oder throw new Exception

            }
            else
                Zaehler = nenner;

        }
        public static Bruch Parse (string str)
        {
            string [] teile = str.Split('/');
            int zahhler = int.Parse(teile[0]);
            int nenner = int.Parse(teile[1]);
            return new Bruch(zahhler, nenner);
        }

        public void kuerzen()
        {
        // 28 - 35
        int kleinster = Math.Min(Zaehler, Nenner);
            for (int i = kleinster; i > 1; i--)
            {
                if (Zaehler % i == 0 && Nenner % i == 0)
                {
                    Zaehler =Zaehler / i;
                    Nenner = Nenner / i;
                    break;
                }
            }
        }
        public void add(Bruch b)
        {
            Bruch bneu = b;
            this.Zaehler = this.Zaehler * b.Nenner+this.Nenner*b.Zaehler;
            this.Nenner = this.Nenner * b.Nenner;
            kuerzen();
        }
        public void subtract(Bruch b)
        {
            this.Zaehler = this.Zaehler * b.Nenner - this.Nenner * b.Zaehler;
            this.Nenner = this.Nenner * b.Nenner;
            kuerzen();
        }
        public void multiply(Bruch b)
        {
            this.Zaehler = this.Zaehler * b.Zaehler;
            this.Nenner = this.Nenner * b.Nenner;
            kuerzen();
        }
        public void divide(Bruch b)
        {
            this.Zaehler = this.Zaehler * b.Nenner;
            this.Nenner = this.Nenner * b.Zaehler;
            kuerzen();
        }

    }
        class Program
    {
        static void Main(string[] args)
        {
            //Eingabe: 67 / 69
            Console.WriteLine("Bitte Bruch angeben");
            string eingabe = Console.ReadLine();
            string eingabe2 = Console.ReadLine();


            Bruch b1 = Bruch.Parse(eingabe);
            Bruch b2 = Bruch.Parse(eingabe2);
            b1.kuerzen();
            b2.add(b1);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());


            Console.ReadKey();
        }
    }
}
