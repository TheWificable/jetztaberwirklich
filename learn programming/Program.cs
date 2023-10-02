// See https://aka.ms/new-console-template for more information


using learn_programming;

Dictionary<int, string> ListeAufgabenhäufigkeit = new Dictionary<int, string>();
ListeAufgabenhäufigkeit.Add(1, "Minütlich");
ListeAufgabenhäufigkeit.Add(2, "Stündlich");
ListeAufgabenhäufigkeit.Add(3, "Täglich");
ListeAufgabenhäufigkeit.Add(4, "Wöchentlich");
ListeAufgabenhäufigkeit.Add(5, "2 Wöchentlich");
ListeAufgabenhäufigkeit.Add(6, "Monatlich");
ListeAufgabenhäufigkeit.Add(7, " pro Quartal");
ListeAufgabenhäufigkeit.Add(8, "Halbjährlich");
ListeAufgabenhäufigkeit.Add(9, "Jährlich");

Dictionary<int, string> ListeAufgabenzeitraum = new Dictionary<int, string>();
ListeAufgabenzeitraum.Add(1, "Minute");
ListeAufgabenzeitraum.Add(2, "Stunde");
ListeAufgabenzeitraum.Add(3, "Tag");
ListeAufgabenzeitraum.Add(4, "Woche");
ListeAufgabenzeitraum.Add(5, "2 Wochen");
ListeAufgabenzeitraum.Add(6, "Monat");
ListeAufgabenzeitraum.Add(7, "Quartal");
ListeAufgabenzeitraum.Add(8, "Halbjahr");
ListeAufgabenzeitraum.Add(9, "Jahr");


Console.WriteLine("\nDiese Programm errechnet, wie hoch die Aufgewendetet Zeit sein darf um eine Aufgabe zu automatisieren. Oder ob man diese manuel erledigt \n Dafür werden gleich folgende Angaben benötigt:\n-1 Wie lange dauert die Aufgabe, wenn sie manuell erledig wird?\n-2 Wie lange dauert es ca. diese Aufgabe zu automatisieren?\n-3 Über welchen Zeitraum fällt diese Aufgabe an?");
Console.Write("{Punkt 1} Wie lange dauert die Aufgabe in Minuten:");
int Aufgabendauer = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
Console.WriteLine("{Punkt 2} Wie Häufig wird die Aufgabe ausgeführt: \n-- (1) Minütlich \n-- (2) Stündlich\n-- (3) Täglich\n-- (4) Wöchentlich\n-- (5) 2- Wöchentlich\n-- (6) Monatlich\n-- (7) Qartal\n-- (8) Halbjahr\n-- (10) Jahr\nausgeführt?");
Console.Write("\n");
Console.Write("Eingabe:");
Console.Write("\n");
int Aufgabenhäufigkeit = Convert.ToInt32(Console.ReadLine());
Console.Write("{Punkt 3} Über welchen Zeitraum wird die Aufgabe ausgeführt");
Console.WriteLine("Wird die Aufgabe.\n-- (1) Die nächste Minute \n-- (2) Die nächste Stunde\n-- (3) Einen Ganzen Tag\n-- (4) Eine ganze Woche lang\n-- (5) 2 Wochen lang\n-- (6) Einen ganzen Monat lang\n-- (7) Ein Qartal lang\n-- (8) Ein halbes Jahr lang\n-- (10) Ein Jahr lang\nausgeführt?");
Console.Write("\n");
Console.Write("Eingabe:");
int Aufgabenzeitraum = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
Console.Write("Deine Aufgabe dauert" + " " + Aufgabendauer + " " + "Minuten, wird " + ListeAufgabenhäufigkeit[Aufgabenhäufigkeit] + " ausgeführt. Und dass für folgenden Zeitraum. Eine(n): " + ListeAufgabenzeitraum[Aufgabenzeitraum]);
Console.Write("\n");
Console.Write("Laut diesen Angaben verbrinst du insgesamt:" + " " + GesamtzeitderAufgabe(Aufgabendauer, Aufgabenhäufigkeit, Aufgabenzeitraum) + " " + "Minuten mit der Aufgabe über den Gesamten Zeitraum");


static int GesamtzeitderAufgabe(int Aufgabendauer, int Aufgabenhäufigkeit, int Aufgabenzeitraum)
{
    int result = Aufgabendauer * Aufgabenhäufigkeit * Aufgabenzeitraum;
    return result;

}



Console.ReadLine();

public class Aufgabenpaar
{
    public int Zahl { get; set; }
    public string Dauer { get; set; }
};