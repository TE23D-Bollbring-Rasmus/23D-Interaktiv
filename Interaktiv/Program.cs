Console.WriteLine("Hej! Är det varmt eller kallt? ");
string temp = Console.ReadLine();

if (temp.ToLower() == "kallt")
{
    Console.WriteLine("Vill du gå framåt eller åt höger?");
    string direction1 = Console.ReadLine();
    if (direction1.ToLower() == "framåt")
    {
        Console.WriteLine("Rätt!");
        Console.ReadLine();
    }
    if (direction1.ToLower() == "höger")
    {
        Console.WriteLine("fel!!!!!!!!!!!!!");
        Console.ReadLine();
    }
}

if (temp.ToLower() == "varmt")
{
    Console.WriteLine("Vill du gå åt vänster eller bakåt?");
    string direction2 = Console.ReadLine();
    if (direction2.ToLower() == "vänster")
    {
        Console.WriteLine("Testa något annat");
        Console.ReadLine();
    }
     if (direction2.ToLower() == "bakåt")
     {
        Console.WriteLine("Testa något annat");
         Console.ReadLine();
     }
}


Console.ReadLine();