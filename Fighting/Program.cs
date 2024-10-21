

int herohp = 100;
int villianhp = 100;

string heroName = "HERO";
string villianName = " VILLIAN";

while ( herohp > 0 && villianhp > 0)

{

Console.WriteLine("\n ---------- NY RUNDA ----------");
Console.WriteLine($" {heroName}: {herohp}   {villianName}:  {villianhp} \n");

int heroDamage =  Random.Shared.Next(20);
villianhp -= heroDamage;
villianhp = Math.Max(0, villianhp);
Console.WriteLine($" {heroName} gör {heroDamage} skada på {villianName} ");


int villianDamage = Random.Shared.Next(20);
herohp -= villianDamage; 
herohp = Math.Max(0, herohp); 
Console.WriteLine($" {villianName} gör {villianDamage} skada på {heroName} ");

Console.WriteLine(" Tryck på valfri knapp för att forsätta ");
Console.ReadKey();
}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (herohp == 0 && villianhp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (herohp == 0)
{
  Console.WriteLine($"{villianName} vann!");
}
else
{
  Console.WriteLine($"{heroName} vann!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();
