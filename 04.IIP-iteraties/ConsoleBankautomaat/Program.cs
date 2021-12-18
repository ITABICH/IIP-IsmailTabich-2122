class Bankautomaat
{
    static void Main(String[] args)
    {
        int saldo = 500;
        string gekozenKeuze = "";
        int invoer;
        char keuze;
        const string AFHALEN = "Welk bedrag wil je afhalen: ";
        const string STORTEN = "Welke Saldo wil je storten: ";
        const string STOP = "Bedankt en tot ziens.";

        Console.WriteLine(@"Bankautomaat
==========");
        do
        {
            Console.WriteLine(@"a. afhaling
b. storting
c. stoppen");
            Console.Write("je keuze: ");
            keuze = Convert.ToChar(Console.ReadLine());
            if (keuze == 'c' || keuze == 'a' || keuze == 'b')
            {
                switch (keuze)
                {
                    case 'a': gekozenKeuze = AFHALEN; break;
                    case 'b': gekozenKeuze = STORTEN; break;
                    case 'c': gekozenKeuze = STOP; break;
                }
                Console.Write($"{gekozenKeuze}");
                invoer = Convert.ToInt32(Console.ReadLine());

                if (gekozenKeuze == AFHALEN)
                {
                    saldo -= invoer;
                    Console.WriteLine($"Het niewe saldo is {saldo}");
                }
                else if (gekozenKeuze == STORTEN)
                {
                    saldo += invoer;
                    Console.WriteLine($"Het niewe saldo is {saldo}");
                }
                else if (gekozenKeuze == STOP)
                {
                    Console.WriteLine($"{STOP}");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Ongeldige keuze");
            }
        } while (keuze != 'c');
    }
}