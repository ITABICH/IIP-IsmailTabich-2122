class Tafels
{
    private static void DrukTafel(int getal, int lengte)
    {
        // vervolledig hier
        for (int i = 1; i <= lengte; i++)
        {
            int resultaat = getal * i;
            Console.WriteLine($"{getal} * {i} = {resultaat}");
        }

        Console.ReadKey();
    }

    static void Main(String[] args)
    {
        Console.Write("Geef een getal: ");
        int getal = Convert.ToInt32(Console.ReadLine());

        Console.Write("Geef een lengte: ");
        int lengte = Convert.ToInt32(Console.ReadLine());

        DrukTafel(getal, lengte);

    }
}
