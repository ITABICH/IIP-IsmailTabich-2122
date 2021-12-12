class Bestelling
{
    const int PRIJS_MARGHERITA = 8;
    const int PRIJS_FUNGHI = 10;
    const int PRIJS_DIABOLO = 11;
    const int PRIJS_BEZORGING = 3;
    static void Main(string[] agrs)
    {
        Console.Write(@"PIZZA BESTELLING
================

Kies je pizza: 
a) Margherita 8 euro
b) Funghi 10 euro
c) Diabolo 11 euro
>>> Wat is je keuze? ");

        char pizza = Convert.ToChar(Console.ReadLine());
        char pizzaKeuze = pizza;


        Console.Write(@"Kies de grootte:
a) 15 cm (klein; - 20%)
b) 20 cm (normaal)
c) 25 cm (groot + 20%)
>>> Wat is je keuze? ");

        char grootte = Convert.ToChar(Console.ReadLine());
        char grootteKeuze = grootte;


        Console.WriteLine("Thuis bezorgen (3 euro extra)? ja/nee: ");
        string bezorging = Console.ReadLine();
        string bezorgingsKeuze = bezorging;

        Console.WriteLine($"Jouw bestelling: 1 pizza {pizzaKeuze} {grootteKeuze}, voor  euro, {bezorgingsKeuze}");
        switch (pizzaKeuze)
        {
            case 'a': Console.WriteLine("Margharita"); break;
            ///prijs = +PRIJS_MARGHERITA;
            case 'b': Console.WriteLine("Funghi"); break;
            ///prijs = +PRIJS_FUNGHI;
            case 'c': Console.WriteLine("Diabolo"); break;
            ///prijs = PRIJS_DIABOLO;
            default: Environment.Exit(0); break;
        }
        switch (grootteKeuze)
        {
            case 'a': Console.WriteLine("klein"); break;
            ///totaal = prijs - ((prijs / 100) * 20);
            case 'b': Console.WriteLine("normaal"); break;
            case 'c': Console.WriteLine("groot"); break;
            ///totaal = prijs + ((prijs / 100) * 20);
            default: Environment.Exit(0); break;
        }

        switch (bezorgingsKeuze)
        {
            case "ja": Console.WriteLine("thuis bezorging"); break;
            ///totaal = +PRIJS_BEZORGING;
            case "nee": Console.WriteLine("afhalen"); break;
            default: Environment.Exit(0); break;
        }
    }
}
