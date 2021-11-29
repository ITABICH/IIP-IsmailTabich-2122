class Hms
{
    static void Main(string[] args)
    {
        //Aantal seconden invoegen
        Console.Write("Geef het aantal seconden: ");
        int aantalSeconden = Convert.ToInt32(Console.ReadLine());

        //Berekening in uren
        int uren = aantalSeconden / 3600;

        //Rest van de berekening in uren
        int restUren = aantalSeconden % 3600;

        //Berekening in minuten
        int minuten = restUren / 60;

        //Rest van de berekening in minuten
        int restMinuten = restUren % 60;

        //Berekening in seconden
        int seconden = restMinuten / 1; 

        //Het omzet van seconden naar uren minuten en seconden
        Console.Write($"Omgezet in hms formaat: {uren}:{minuten}:{seconden} ");

    }
}
