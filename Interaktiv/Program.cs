Console.WriteLine("Hej och välkommen till denna frågesport");
string fråga1 = Console.ReadLine();
Console.WriteLine("Vad är störst, a en elefant, b en giraff, c ett lejon?")

if (fråga1.ToLower() == "a")
{
    Console.WriteLine("Korrekt!");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Nej, det var Elefant!");
    Console.ReadLine();
}


Console.ReadLine();