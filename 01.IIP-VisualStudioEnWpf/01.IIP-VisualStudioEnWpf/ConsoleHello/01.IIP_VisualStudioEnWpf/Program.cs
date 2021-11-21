// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.Write("Hoe heet je? ");
        String naam = Console.ReadLine();
        Console.Write("Aangenaam kennismaking,");
        Console.WriteLine(naam);
        Console.WriteLine("druk een toets om verder te gaan...");
        Console.ReadLine();
        //Opgave 1
    
        Console.WriteLine("Jantje zag eens pruimen hangen,");
        Console.ReadKey();
        Console.WriteLine("O! als eieren zo groot.");
        Console.ReadKey();
        Console.WriteLine("'t scheen, dat Jantje wou gaan plukken,");
        Console.ReadLine();
        //Opgave 2

        Console.WriteLine("    ##          ##");
        Console.WriteLine("      ##      ##");
        Console.WriteLine("    ##############");
        Console.WriteLine("  ####  ######  ####");
        Console.WriteLine("######################");
        Console.WriteLine("##  ##############  ##");
        Console.WriteLine("##  ##          ##  ##");
        Console.WriteLine("      ####  ####");
        Console.ReadLine();
        //Opgave 3
    
        Console.WriteLine("*** WELKOM BIJ GREENHOUSE RESTAURANT ***");
        Console.WriteLine("=========================================");
        Console.ReadLine();
        Console.Write("Kies een grootte (kleine of grote):");
        string grootte = Console.ReadLine();
        Console.Write("Kies een basis (quinoa, rijst of salade):");
        string basis = Console.ReadLine();
        Console.Write("Kies een soort (vegan, zalm of kip):");
        string soort = Console.ReadLine();
        Console.WriteLine("Je besteling: een " + grootte + " " + basis + " met " + soort);
        Console.ReadKey();
        //Opgave 4
    }

}


