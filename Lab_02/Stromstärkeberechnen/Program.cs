// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geben sie den Wert für den Widerstand an");
string eingabe = Console.ReadLine();
int positionzahl=0;
int positionhochzahl=0;
bool falscheAngabe;




for(int i = 0;i<eingabe.Length;i++)
{

    if(eingabe[i] =='k' || eingabe[i] == 'o' || eingabe[i] == 'M' )
    {
        positionzahl = i - 1;
        positionhochzahl = i;
    }
    
}

int zahlStr = int.Parse(eingabe.Substring(0, positionzahl));
if(eingabe[positionhochzahl]=='k')
{
    zahlStr = zahlStr * (10 ^ 3);
    Console.WriteLine("Widerstand={0}", zahlStr);
}
else if(eingabe[positionhochzahl] == 'M')
{
    zahlStr = zahlStr * (10 ^ 6);
    Console.WriteLine("Widerstand={0}", zahlStr);
}
else if(eingabe[positionhochzahl] == 'o')
{
Console.WriteLine("Widerstand={0}",zahlStr);
}
else
{ Console.WriteLine("Falsche Angabe");
falscheAngabe = true;
}
int Widerstand = zahlStr;

Console.WriteLine("Geben sie den Wert für die Spannung an");
eingabe = Console.ReadLine();
positionzahl = 0;
positionhochzahl = 0;




for (int i = 0; i < eingabe.Length; i++)
{

    if (eingabe[i] == 'k' || eingabe[i] == 'o' || eingabe[i] == 'm')
    {
        positionzahl = i - 1;
        positionhochzahl = i;
    }

}

zahlStr = int.Parse(eingabe.Substring(0, positionzahl));
if (eingabe[positionhochzahl] == 'k')
{
    zahlStr = zahlStr * (10 ^ 3);
    Console.WriteLine("Widerstand={0}", zahlStr);
}
else if (eingabe[positionhochzahl] == 'm')
{
    zahlStr = zahlStr * (10 ^ -3);
    Console.WriteLine("Widerstand={0}", zahlStr);
}
else if (eingabe[positionhochzahl] == 'o')
{
    Console.WriteLine("Widerstand={0}", zahlStr);
}
else
{ Console.WriteLine("Falsche Angabe"); falscheAngabe = true; }



    Console.ReadKey();
