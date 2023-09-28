Random generator = new Random();
int Jhp = 100;
int Mhp = 75;
int Runda = 1;
Console.WriteLine("Hej Hej, välj ditt namn");
string Jnamn = Console.ReadLine();

while (Jhp > 0 && Mhp > 0)
{
    Console.WriteLine($"Runda: {Runda}");
    Runda++;

    int slumptal1 = generator.Next(10,40);  
    int slumptal2 = generator.Next(5,50);
    Mhp = Mhp - slumptal1;
    Jhp = Jhp - slumptal2;
    Console.WriteLine($"Motstondaren tog {slumptal1} i skadda och har nu {Mhp} hp");
    Console.ReadLine();
    Console.WriteLine($"Motstondaren slår tillbaka och du tar {slumptal2} i skadda detta ger dig {Jhp}");
    Console.ReadLine();
}
Console.ReadLine();