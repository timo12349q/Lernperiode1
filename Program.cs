Console.WriteLine("Wie heisst du?");
string name = Console.ReadLine();
Console.WriteLine("Willkommen " + name + " zum Quiz über unser Sonnensystem.");
int richtig = 0;
Console.WriteLine("1. Wie viele Planeten gibt es in unserem Sonnensystem?");
int antwort1 = Convert.ToInt32(Console.ReadLine());
int richtigeAntwort1 = 8;
if (antwort1 == richtigeAntwort1)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("2. Ist der Merkur der kleinste Planet in unserem Sonnensystem? (ja/nein)");
string antwort2 = Console.ReadLine();
string richtigeAntwort2 = "ja";
if (antwort2 == richtigeAntwort2)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("3. Welcher Planet ist der grösste in unserem Sonnensystem?");
string antwort3 = Console.ReadLine();
string richtigeAntwort3 = "Jupiter";
if (antwort3 == richtigeAntwort3)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("4. Wie viel Kilometer ist der Mond von der Erde entfernt?");
Console.WriteLine("Tipp: Die Entfernung liegt zwischen 350 Tausend und 400 Tausend Kilometer.");
int antwort4 = Convert.ToInt32(Console.ReadLine());
if (antwort4 == 384400)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("5. Welcher Planet ist der heisseste in unserem Sonnensystem?");
string antwort5 = Console.ReadLine();
string richtigeAntwort5 = "Venus";
if (antwort5 == richtigeAntwort5)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("6. Welcher Planet ist der kälteste in unserem Sonnensystem?");
string antwort6 = Console.ReadLine();
string richtigeAntwort6 = "Neptun";
if (antwort6 == richtigeAntwort6)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("7. Welcher Planet wird als der Rote Planet bezeichnet?");
string antwort7 = Console.ReadLine();
string richtigeAntwort7 = "Mars";
if (antwort7 == richtigeAntwort7)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("8. Welcher Planet hat die meisten Monde?");
string antwort8 = Console.ReadLine();
string richtigeAntwort8 = "Jupiter";
if (antwort8 == richtigeAntwort8)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("9. Welcher Planet ist der Sonne am nächsten?");
string antwort9 = Console.ReadLine();
string richtigeAntwort9 = "Merkur";
if (antwort9 == richtigeAntwort9)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("10. Welcher Planet ist der Sonne am weitesten entfernt?");
string antwort10 = Console.ReadLine();
string richtigeAntwort10 = "Neptun";
if (antwort10 == richtigeAntwort10)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("Sie haben das Quiz abgeschlossen.");
Console.WriteLine("Sie haben " + richtig + " von 10 Fragen richtig.");