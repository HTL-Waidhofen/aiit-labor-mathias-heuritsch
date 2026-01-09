using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labdesnochnwiderstand
{

    class Resistor //Klasse Bauplan
    {
        //Atribute/Membervariablen
        private string label; //Bezeichnung z.B. R1
        private double value; //Widerstandswert
        private double toleranz;//zb 1 wie 1%
        private double maxPower;//zb. 10 fuer 10 Watt

        //Methoden
        //Konstruktor
        public Resistor(string label, double value, double toleranz, double maxPower)
        {
            this.value = value;
            this.label = label;
            this.toleranz = toleranz;
            this.maxPower = maxPower;
        }
        //zugriffsmethoden: Getter und Setter
        public double GetValue()
        { return value; }

        public double calculatecurrent(double voltage)
        {
            double current = voltage / value;
            return current;
        }
        public double calculatevoltage(double current)
        {
            double voltage = current * value;
            return voltage;
        }
        public Resistor Seriel (Resistor r)
        {
            string newLabel = "Rges";
            double newVal = r.value + this.value;

            Resistor ges = new Resistor(newLabel, newVal, toleranz, maxPower);
            


            return ges;
        }

        public Resistor paralel(Resistor r)
        {
            string newLabel = "Rges";
            double newVal = 1/(1/r.value + 1/this.value);

            Resistor ges = new Resistor(newLabel, newVal, toleranz, maxPower);



            return ges;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe = Console.ReadLine();
            string[] geteilt = eingabe.Split(new string[] { "ohm" }, StringSplitOptions.None);

            //Objekte sind Instanzen der Klasse
            Resistor r1 = new Resistor("R1",100,5,10);
            Resistor r2 = new Resistor("R2",200,1,20);
            int voltage = 24;
            double erg = r1.calculatecurrent(voltage);

            Resistor Rges = r1.Seriel(r2);

        }
    }
}
