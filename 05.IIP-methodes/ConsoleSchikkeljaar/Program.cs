class ConsoleSchikkeljaar
{
    private static string Schikkeljaar(int jaar)
    {
        string antwoord = "";
        if (jaar <= 0)
        {
            antwoord += "De programma zal sluiten";
        }
        else if (jaar % 4 == 0 && jaar % 100 != 0 || jaar % 400 == 0)
        {
            antwoord += $"Het jaar {jaar} is een schikkeljaar";
        }
        else
        {
            antwoord += $"Het jaar {jaar} is geen schikkeljaar";
        }
        return antwoord;
    }

    private static void DrukMenu()
    {
        int invoer;
        do
        {
            Console.Write("Geef een jaartal: ");
            invoer = Convert.ToInt32(Console.ReadLine());

            string resultaat = Schikkeljaar(invoer);
            Console.WriteLine(resultaat);
        } while (invoer != 0);

        return;
    }
    static void Main(String[] Args)
    {
        Console.WriteLine(@"SCHIKKELJAAR
============");
        
        DrukMenu();

        Console.ReadKey();
        
    }
}