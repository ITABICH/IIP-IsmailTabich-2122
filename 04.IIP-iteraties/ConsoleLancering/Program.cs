class Lancering
{
    static void Main(string[] args)
    {
        Console.Write("Hoeveel seconden tot lancering? ");
        int seconden = Convert.ToInt32(Console.ReadLine());

        for (int i = seconden; i > 0; i--)
        {
            seconden = i;
            Console.Write($"{seconden} ...");
            Console.ReadLine();
        }

        Console.WriteLine("Lift off!");
        Console.ReadKey();

    }
}