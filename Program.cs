using System.Globalization;

Console.WriteLine("Wie heisst du?");
string name = Console.ReadLine();
Console.WriteLine("Willkommen " + name + "zum Quiz über unser Sonnensystem.");
Console.WriteLine("Wie viele Planeten gibt es in unserem Sonnensystem?"); 
int antwort1 = Convert.ToInt32(Console.ReadLine());
int richtigeAntwort1 = 8;
if  (antwort1 == richtigeAntwort1)
Console.WriteLine("Richtige Antwort");
else
    Console.WriteLine("Falsche Antwort!");
Console.WriteLine("Ist der Merkur der kleinste Planet in unserem Sonnensystem? (ja/nein)");
string antwort2 = Console.ReadLine();
string richtigeAntwort2 = "ja";
if (antwort2 == richtigeAntwort2)
    Console.WriteLine("Richtige Antwort");
else
    Console.WriteLine("Falsche Antwort!");
