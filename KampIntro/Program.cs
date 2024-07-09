internal class Program
{
    private static void Main(string[] args)
    {
        //Type safety = tip güvenliği
        // Do not yourself - Kendini tekrarlama 
        string kategoriEtiketi = "Kategoriler";
        int ogrenciSyisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMı = true;

        double dolarDün = 7.35;
        double dolarBugün = 7.45;

        if (dolarDün>dolarBugün)
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarDün<dolarBugün)
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("Eşittir Butonu");
        }






        if (sistemeGirisYapmisMı==true)
        {
            Console.WriteLine("Kullanıcı Ayarlrı Butonu");
        }
        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }






        Console.WriteLine(kategoriEtiketi);

    }
}