namespace FirstApp
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Kniha kniha1 = new Kniha("škola", "Božena Němcová", 1945);
            Ebook ebook1 = new Ebook("Válka", "Neznámý", 2012, 7.4, "Word");

           
            Knihovna.PridatKnihu(kniha1);
            Knihovna.PridatKnihu(ebook1);

           
            Knihovna.VypisVsechnyKnihy();

             
            Console.WriteLine($"Počet knih v knihovně: {Knihovna.PocetKnih}");
        }
    }

}