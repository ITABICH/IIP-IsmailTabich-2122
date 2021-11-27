using System.Text;

class Karakter
{
    static void Main(string[] args)
    {

        //Geef een letter in
        Console.Write("Geef een kleine letter: ");
        char letter = Convert.ToChar(Console.ReadLine());

        //Het letternummer van de vorige letter uit de ASCII
        Console.WriteLine($"Het nummer is " + (byte)letter);

        //De hoofdletter aantonon
        Console.WriteLine("De hoofdletter is " + (char)Convert.ToChar(letter - 32));

        //De vorige letter van de initiale letter
        Console.WriteLine("De vorige letter is " + (char)Convert.ToChar(letter+1));

        //De volgende letter van de initiale letter
        Console.WriteLine("De volgende letter is " + (char)Convert.ToChar(letter-1));
    }
}
