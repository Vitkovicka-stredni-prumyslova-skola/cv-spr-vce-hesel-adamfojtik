namespace FirstApp
{
    public class Kniha
    {
        //vlastnosti třídy
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public int RokVydani { get; set; }

    //kontrukor pro třídu
        public Kniha(string nazev, string autor, int rokvydani)
        {
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokvydani;
        }
    
        public virtual void VypisInformace()
        { 
            Console.WriteLine($"Název: {Nazev}, Autor: {Autor}, Rok vydání: {RokVydani}");
        }
    }

    public class Ebook : Kniha
    { 
        public double VelikostSouboru { get; set; }
        public string Format { get; set; }

        public Ebook(string nazev, string autor, int rokvydani, double velikostSouboru, string format)
            : base(nazev, autor, rokvydani)
        {
            VelikostSouboru = velikostSouboru;
            Format = format;
        }

        public override void VypisInformace()
        {
            base.VypisInformace();
            Console.WriteLine($"Velikost souboru: {VelikostSouboru} MB, Formát: {Format}");
        }
    }

    public static class Knihovna
    {
        
        public static int PocetKnih { get; private set; }

        
        private static List<Kniha> knihy = new List<Kniha>();

        
        public static void PridatKnihu(Kniha kniha)
        {
            knihy.Add(kniha);      
            PocetKnih++;           
        }

       
        public static void VypisVsechnyKnihy()
        { //prochazi vsechny knihy v seznamu
            foreach (var kniha in knihy)
            {
                kniha.VypisInformace(); // metoda kterou chceme vypsat vse o knize
            }
        }
    }
}