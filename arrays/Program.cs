string[] planes; // deklarace pole typu string, které bude obsahovat názvy letadel //
planes = new string[3]; // inicializace pole s velikostí 3, což znamená, že pole může obsahovat 3 hodnoty typu string. V tomto okamžiku jsou všechny hodnoty v poli null. //
planes = new string[] { "f-14", "F-15", "F-16" }; // inicializace pole s třemi hodnotami //
planes[0] = "F-14"; // přepsání hodnoty na indexu 0 v poli planes z "f-14" na "F-14" //
int index = 0;


Console.WriteLine($"Chceš prepsat hodnoty proměne planes z | F-14, F-15, F-16 |  na  | Rafale, Tomcat, Eurofighter | ?");
Console.WriteLine("ano / ne");

if (Console.ReadLine() == "ano")
{
    Console.Clear();
    Console.WriteLine("Hodnoty proměne *planes* byly přepsány.");
    planes = new string[] { "Rafale", "Gripen", "Eurofighter" };  // přepsání všech hodnot v poli planes novými hodnotami //
}
else
{
    Console.Clear();
    Console.WriteLine("Hodnoty proměne *planes* nebyly přepsány.");
}

Console.WriteLine();
Console.WriteLine("jake letadlo z dostupnych je nejlepší?");
Console.WriteLine($"dostupne: {string.Join(" | ", planes)}"); // výpis všech dostupných letadel pro uživatele //
index = Array.IndexOf(planes, Console.ReadLine()); // získání indexu letadla od uživatele pomocí Array.IndexOf//
Console.WriteLine(index);
Console.Clear();

if (index == -1) // pokud uživatel zadá letadlo, které není v poli, Array.IndexOf vrátí -1 //
{
    Console.WriteLine("Letadlo není mezi dostupnými nebo chyba vstupu.");
    Environment.Exit(0);
}
else // výpis letadla s indexem {index} //
{
    Console.WriteLine($"{planes[index]} je pro tebe nejlepší letadlo.");
}
Console.WriteLine(planes[index][0]); // výpis prvního znaku letadla na indexu {index}//
foreach (char pismeno in planes[index]) // výpis všech znaků letadla na indexu {index} pomocí foreach cyklu //
{
    Console.Write(pismeno + " | ");
}
Console.WriteLine();
Console.WriteLine(string.Join(" | ", planes[index].ToCharArray())); // pokročilí výpis všech znaků letadla na indexu {index} pomocí string.Join a ToCharArray() //

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("length:\t\t" + planes.Length); // výpis délky pole //
Console.WriteLine("all:\t\t" + string.Join(" | ", planes)); // výpis všech hodnot v poli pomocí string.Join //
Console.WriteLine("plane[1]:\t" + planes[1]); // výpis hodnoty na indexu 1 v poli //
Console.WriteLine();
