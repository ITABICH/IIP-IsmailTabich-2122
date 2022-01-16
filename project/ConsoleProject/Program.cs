using System;
using System.Text;
namespace ConsoleProject
{
    class Program
    {
        private const int EINDMEET = 60;

        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine(@"SLAKKENRACE
+++++++++++" + Environment.NewLine);

            Console.ReadLine();
            Console.Clear();

            List<string> slak = new List<string>();

            Console.WriteLine("Geef een symbool aan jouw slak" + Environment.NewLine);

            Console.Write("Slak 1:");
            string slak1 = Console.ReadLine();
            slak.Add(slak1);

            Console.WriteLine("Druk op een knop om te starten!");
            Console.ReadLine();

            int beweging = rnd.Next(1, 3);
            string str = new StringBuilder("-".Length * beweging).Insert(0, "-", 60).ToString();
            Console.WriteLine(str);







        }
    }
}