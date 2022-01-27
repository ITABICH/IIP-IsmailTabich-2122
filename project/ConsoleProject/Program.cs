using System;
using System.Text;
using System.Threading;
using WMPLib;


namespace ConsoleProject
{
    class Program
    {
        //Einde race
        private const int EINDMEET = 60;

        //Minimum en maximum aantal pause
        private const int MINIMUM_PAUSE = 100;
        private const int MAXIMUM_PAUSE = 500;

        //Random aanmaken
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            ///Race muziek aanmaken
            WindowsMediaPlayer raceMuziek = new WindowsMediaPlayer();

            ///Race muziek geven
            raceMuziek.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Geluiden/race.mp3");
            raceMuziek.controls.stop();

            Console.WriteLine(@"SLANGENRACE
////////////" + Environment.NewLine);
            
            Console.ReadLine();

            Console.Clear();

            ///Drie verschillende slangen tonen
            Console.WriteLine("Drie slangen, de slang die het snelst het parkoer aflegt wint1! \n1) = \n2) + \n3) >");

            ///Vragen welke slang zal winnen
            Console.WriteLine("Welke slang zal winnen? Kies een van de bovenste. ");
            char winnaar = Convert.ToChar(Console.ReadLine());

            ///Inzet vragen en geven
            Console.Write("Jouw inzet: ");
            int inzet = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            ///Muziek activeren
            raceMuziek.controls.play();

            ///Eerste race tonen
            Race1();

            ///Muziek uitschakkenen
            raceMuziek.controls.stop();

            Console.WriteLine(Environment.NewLine);

            ///Muziek activeren
            raceMuziek.controls.play();

            ///Eerste race tonen
            Race2();

            ///Muziek uitschakkenen
            raceMuziek.controls.stop();


            Console.WriteLine(Environment.NewLine);

            ///Muziek activeren
            raceMuziek.controls.play();

            ///Eerste race tonen
            Race3();

            ///Muziek uitschakkenen
            raceMuziek.controls.stop();
        }

        private static void Race1()
        {
            ///Array aanmaken en een groote geven
            char[] slang = new char[EINDMEET];

            ///Slang1 is het symbool =
            slang[0] = '=';

            for (int i = 0; i < EINDMEET; i++)
            {
                ///Pause tussen elke stap
                System.Threading.Thread.Sleep(rnd.Next(MINIMUM_PAUSE, MAXIMUM_PAUSE));

                Console.Write($"{slang[i] = slang[0]}");

            }
            return;
        }

        private static void Race2()
        {
            ///Array aanmaken en een groote geven
            char[] slang = new char[EINDMEET];
            ///Slang2 is het symbool +
            slang[0] = '+';

            ///
            for (int i = 0; i < EINDMEET; i++)
            {
                ///Pause tussen elke stap
                System.Threading.Thread.Sleep(rnd.Next(MINIMUM_PAUSE, MAXIMUM_PAUSE));

                Console.Write($"{slang[i] = slang[0]}");
            }
            return;
        }

        private static void Race3()
        {
            ///Array aanmaken en een groote geven
            char[] slang = new char[EINDMEET];

            ///Slang3 is het symbool >
            slang[0] = '>';

            ///Slang loopt tot het einde
            for (int i = 0; i < EINDMEET; i++)
            {
                ///Pause tussen elke stap
                System.Threading.Thread.Sleep(rnd.Next(MINIMUM_PAUSE, MAXIMUM_PAUSE));

                Console.Write($"{slang[i] = slang[0]}");

            }
            return;
        }
    }
}