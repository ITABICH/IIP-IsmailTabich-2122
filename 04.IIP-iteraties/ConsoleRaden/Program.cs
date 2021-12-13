class Raden
{
    static void Main(String[] args)
    {
        int geheimGetal = 3;
        Console.WriteLine("Raad een getal tussen 0 en 10");


        int poging = 0;
        int getal;
       
        do
        {
            poging++;
            if (poging > 3)
            {
                Console.WriteLine("Volgende keer beter");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            Console.Write($"Poging {poging}: ");
            getal = Convert.ToInt32(Console.ReadLine());
            
            
        }
        while (getal != geheimGetal);
        Console.WriteLine("Geraden!");
    }
}