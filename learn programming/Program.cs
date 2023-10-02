// See https://aka.ms/new-console-template for more information


using learn_programming;

int Aufgabendauer_Minütlich = 1;
int Aufgabendauer_Stündlich = 2;
int Aufgabendauer_Täglich = 3;
int Aufgabendauer_Wöchentlich = 4;
int Aufgabendauer_ZweiWöchentlich = 5;
int Aufgabendauer_Monatlich = 6;
int Aufgabendauer_Quartal = 7;
int Aufgabendauer_Halbjahr = 8;
int Aufgabendauer_Jahr = 9;

var ListeAufgabendauerr = new List<Aufgabenpaar>
{
    new() { Zahl = 0, Dauer = "Minütlich" },
    new() { Zahl = 1, Dauer = "Stündlichz" },
    new() { Zahl = 0, Dauer = "Täglich" }


};

foreach (Aufgabenpaar Aufgabenpaaaaar in ListeAufgabendauerr)
{
    Console.WriteLine(Aufgabenpaaaaar.Zahl + " " + Aufgabenpaaaaar.Dauer);
}


Console.WriteLine("Diese Programm errechnet, wie hoch die Aufgewendetet Zeit sein darf um eine Aufgabe zu automatisieren. Oder ob man diese manuel erledigt \n Dafür werden gleich folgende Angaben benötigt:\n-1 Wie lange dauert die Aufgabe, wenn sie manuell erledig wird?\n-2 Wie lange dauert es ca. diese Aufgabe zu automatisieren?");
Console.Write("Wie lange dauert die Aufgabe in Minuten:");
int Aufgabendauer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Wird die Aufgabe.\n-- Minütlich (1)\n-- Stündlich(2)\n-- Täglich(3)\n-- Wöchentlich(4)\n-- 2- Wöchentlich(5)\n-- Monatlich(6)\n-- Qartal(7)\n-- Halbjahr(8)\n-- Jahr(10)\nausgeführt?");
Console.Write("Eingabe:");
int Aufgabenhäufigkeit = Convert.ToInt32(Console.ReadLine());
Console.Write("Über welchen Zeitraum wird die Aufgab ausgeführt");
Console.WriteLine("Wird die Aufgabe.\n-- Die nächste Minute (1)\n-- Die nächste Stunde(2)\n-- Einen Ganzen Tag(3)\n-- Eine ganze Woche lang(4)\n-- 2 Wochen lang(5)\n-- Einen ganzen Monat lang(6)\n-- Ein Qartal(7) lang\n-- Ein halbes Jahr lang(8)\n-- Ein Jahr lang(10)\nausgeführt?");
int Aufgabenzeitraum = Convert.ToInt32(Console.ReadLine());


Aufgabe Aufgabe1 = new Aufgabe(Aufgabendauer, Aufgabenzeitraum, Aufgabenhäufigkeit);

Console.Write("Deine Aufgabe dauert " + Aufgabe1.Aufgabendauer + "Minuten, wird " + Aufgabe1.Aufgabenhäufigkeit + "durchgeführt für die nächsten " + Aufgabe1.Aufgabenzeitraum + ".");


Console.ReadLine();

public class Aufgabenpaar
{
    public int Zahl { get; set; }
    public string Dauer { get; set; }
}