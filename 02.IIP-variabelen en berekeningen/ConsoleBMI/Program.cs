class BMI
{


    static void Main(string[] args)
    {
        Console.WriteLine("BMI CALCULATOR");
        Console.WriteLine("==============");

        //Lengte tijpen
        Console.Write("Lengte (in cm): ");
        int lengteCm = Convert.ToInt32(Console.ReadLine());
        //Voor dat ik de Youtube Video heb gezien ==> string lengteCm = Console.ReadLine();

        //Gewicht tijpen
        Console.Write("Gewicht (in kg):");
        int gewicht = Convert.ToInt32(Console.ReadLine());
        // Voor dat ik de Youtube Video heb gezien ==> string gewicht = Console.ReadLine();

        //Lengte van centimeter naar meter wisselen
        double lengteM = Convert.ToDouble(lengteCm) / 100;  
        

        //Berekening van het BMI
        double BMI = Convert.ToDouble(gewicht) / (lengteM * lengteM);

        //Het resultaat van de BMI berekening
        Console.Write($"Je BMI bedraagt: " + (BMI = Math.Round(BMI, 2)));
    }
}
