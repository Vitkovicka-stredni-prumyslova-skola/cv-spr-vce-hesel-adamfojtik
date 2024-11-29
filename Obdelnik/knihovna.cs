using FirstApp;

class Program
{
    static void Main()
    {
        Kniha kniha1 = new Kniha("Kniha1", "autor",2000);
        Ebook Ebook1 = new Ebook("Ebook1", "autor", 2000);

        


        Console.WriteLine(kniha1.VypisInformace());
        Console.WriteLine(ebook1.VypisInformace());


    }
}