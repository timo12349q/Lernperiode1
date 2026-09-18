Console.WriteLine("Wie heisst du?");
string name = Console.ReadLine();
Console.WriteLine("Willkommen " + name + " zum Quiz über unser Sonnensystem.");
int richtig = 0;
int falsch = 0;
Console.WriteLine("1. Wie viele Planeten gibt es in unserem Sonnensystem?");
int answer1 = Convert.ToInt32(Console.ReadLine());
int correctAnswer1 = 8;
if (answer1 == correctAnswer1)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("2. Ist der Merkur der kleinste Planet in unserem Sonnensystem? (ja/nein)");
string answer2 = Console.ReadLine();
string correctAnswer2 = "ja";
if (answer2 == correctAnswer2) 
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("3. Welcher Planet ist der grösste in unserem Sonnensystem?");
string answer3 = Console.ReadLine();
string correctAnswer3 = "Jupiter";
if (answer3 == correctAnswer3)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("4. Wie viel Kilometer ist der Mond von der Erde entfernt?");
Console.WriteLine("Tipp: Die Entfernung liegt zwischen 350 Tausend und 400 Tausend Kilometer.");
int answer4 = Convert.ToInt32(Console.ReadLine());
if (answer4 == 384400)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("5. Welcher Planet ist der heisseste in unserem Sonnensystem?");
string answer5 = Console.ReadLine();
string correctAnswer5 = "Venus";
if (answer5 == correctAnswer5)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("6. Welcher Planet ist der kälteste in unserem Sonnensystem?");
string answer6 = Console.ReadLine();
string correctAnswer6 = "Neptun";
if (answer6 == correctAnswer6)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("7. Welcher Planet wird als der Rote Planet bezeichnet?");
string answer7 = Console.ReadLine();
string correctAnswer7 = "Mars";
if (answer7 == correctAnswer7)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("8. Welcher Planet hat die meisten Monde?");
string answer8 = Console.ReadLine();
string correctAnswer8 = "Jupiter";
if (answer8 == correctAnswer8)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("9. Welcher Planet ist der Sonne am nächsten?");
string answer9 = Console.ReadLine();
string correctAnswer9 = "Merkur";
if (answer9 == correctAnswer9)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("10. Welcher Planet ist der Sonne am weitesten entfernt?");
string answer10 = Console.ReadLine();
string correctAnswer10 = "Neptun";
if (answer10 == correctAnswer10)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("11. Welcher Planet ist der Erde am ähnlichsten?");
string answer11 = Console.ReadLine();
string correctAnswer11 = "Venus";
if (answer11 == correctAnswer11)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("12. Welcher Planet hat die kürzeste Umlaufzeit um die Sonne?");
string answer12 = Console.ReadLine();
string correctAnswer12 = "Merkur";
if (answer12 == correctAnswer12)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("13. Welcher Planet hat die längste Umlaufzeit um die Sonne?");
string answer13 = Console.ReadLine();
string correctAnswer13 = "Neptun";
if (answer13 == correctAnswer13)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("14. Welcher Planet hat die grössten Ringe?");
string answer14 = Console.ReadLine();
string correctAnswer14 = "Saturn";
if (answer14 == correctAnswer14)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("15. Wie viel Prozent der Erdoberfläche ist mit Wasser bedeckt?");
int answer15 = Convert.ToInt32(Console.ReadLine());
int correctAnswer15 = 71;
if (answer15 == correctAnswer15)
{
    richtig++;
    Console.WriteLine("Richtige Antwort");
}
else
{
    falsch++;
    Console.WriteLine("Falsche Antwort!");
}
Console.WriteLine("Sie haben das Quiz abgeschlossen.");
Console.WriteLine("Sie haben " + richtig + " Fragen richtig beantwortet.");
Console.WriteLine("Sie haben " + falsch + " Fragen falsch beantwortet."); 