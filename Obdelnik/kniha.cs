namespace FirstApp
{
   
    public abstract class Kniha
    {
        
        public string Nazev;
        public string Autor;
        public int RokVydani;

      
        public Kniha(string nazev, string autor, int rokVydani)
        {
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokVydani;
        }

       
        public abstract string VypisInformace();
    }

   
    public class Ebook : Kniha
    {
        public double VelikostSouboru;
        public string Format;

        public Ebook(string nazev, string autor, int rokVydani, double velikostSouboru, string format){
            Nazev = nazev;
            Autor = autor;
            RokVydani = rokVydani;

            
            VelikostSouboru = velikostSouboru;
            Format = format;
        }

            public override string VypisInformace()
        {
            
        } 




    }
}