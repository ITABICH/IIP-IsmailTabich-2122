class BMI
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("BMI CALCULATOR");
        Console.WriteLine("==============");
        Console.ReadLine();

        double Lengte;
        double Gewicht;

        Console.Write($"Lengte (in cm): ");
        Lengte = Console.Read();
        Console.ReadLine();
        Console.Write($"Gewicht (in kg): ");
        Gewicht = Console.Read();
        double BMI;
        BMI= Gewicht / ((Lengte /100) * 2);
        Console.Write($"Je BMI bedraagt: " + (BMI));
    }
}
