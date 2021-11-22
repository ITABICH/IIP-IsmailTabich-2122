// See https://aka.ms/new-console-template for more information
class GreenHouse
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** WELKOM BIJ GREENHOUSE RESTAURANT ***");
        Console.WriteLine("=========================================");
        Console.ReadLine();
        Console.Write("Kies een grootte (kleine of grote):");
        string grootte = Console.ReadLine();
        Console.Write("Kies een basis (quinoa, rijst of salade):");
        string basis = Console.ReadLine();
        Console.Write("Kies een soort (vegan, zalm of kip):");
        string soort = Console.ReadLine();
        Console.WriteLine($"Je besteling: een {grootte} {basis} met {soort}");
        Console.ReadKey();

        //Of 
        //Console.WriteLine("Je besteling: een" + grootte + " " + basis + " met " + soort);

    }
}
