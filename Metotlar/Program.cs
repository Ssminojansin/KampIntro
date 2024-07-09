using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.Id = 1;
        urun1.Adi = " Elma";
        urun1.Aciklama = " Amasya Elması";
        urun1.Fiyati = 15;
        urun1.stokAdedi = 10;

        Urun urun2 = new Urun();
        urun2.Id = 2;
        urun2.Adi = " Karpuz";
        urun2.Aciklama = " Diyarbakır Karpuzu";
        urun2.Fiyati = 80;
        urun2.stokAdedi = 6;

        Urun[] urunler = new Urun[] { urun1, urun2, };

        foreach (Urun urun in urunler)
        {
            Console.WriteLine("//  Ürün adı : " + urun.Adi + "//  Ürün Açıklaması : " + urun.Aciklama + "//  Ürün Fiyatı : " + urun.Fiyati + "TL");
        }

        Console.WriteLine("-------------------------Methodlar------------------------");

        //İntance - Örnek oluşturmak
        //Manager methodunu çağırmak 

        //Encapsulation tam olarak budur.
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("Armut","Yesil Armut", 12,10);
        sepetManager.Ekle2("Elma", "Yesil Elma", 16,8);
        sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 18,6);

    }
}




//Metotlar tekrar tekrar kullanılmayı sağlar.