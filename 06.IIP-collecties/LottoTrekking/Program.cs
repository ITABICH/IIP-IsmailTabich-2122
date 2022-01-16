namespace LottoTrekking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] trekking = { 3, 8, 12, 17, 5, 36, 40 };

            int[] poging = new int[5];

            List<int> juiste = new List<int>();

            for (int i = 0; i < poging.Length; i++)
            {
                Console.Write($"Pogning {i + 1}: ");
                poging[i] = Convert.ToInt32(Console.ReadLine());
                if (poging[i] == trekking[0] || poging[i] == trekking[1] || poging[i] == trekking[2] ||
                    poging[i] == trekking[3] || poging[i] == trekking[4] || poging[i] == trekking[5] ||
                    poging[i] == trekking[6])
                {
                    juiste.Add(poging[i]);
                }
            }

            Console.WriteLine("De geraden getallen zijn: " + String.Join(" - ", juiste));
            Console.WriteLine("Het aantal juiste getallen: " + juiste.Count);
        }
    }
}