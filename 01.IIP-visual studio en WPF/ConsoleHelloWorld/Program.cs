// See https://aka.ms/new-console-template for more information
class HelloWorld
{
    static void Main(string[] args){

        Console.WriteLine("Hello, Wereld!");
        Console.Write("Hoe heet je? ");
        String naam = Console.ReadLine();
        Console.Write("Aangenaam kennismaking,");
        Console.WriteLine(naam);
        Console.WriteLine("druk een toets om verder te gaan...");
        Console.ReadLine();
    }
}

