Random generator = new Random();
int Jhp = 100;
int Mhp = 75;
int Runda = 1;
Console.WriteLine("Hej Hej, välj ditt namn");
string Jnamn = Console.ReadLine();

while (Jhp > 0 & Mhp > 0)
{
    Console.WriteLine(Runda);
    Runda++;

    int slumptal = generator.Next(10,40);  
    Mhp = Mhp - slumptal;
    Console.WriteLine("Motstondaren tog" slumptal " i skadda och har nu " Mhp);
      
}
Console.ReadLine();