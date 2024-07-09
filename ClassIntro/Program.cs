internal class Program
{
    private static void Main(string[] args)
    {
        string ad = "Coskun";
        int yas = 30;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Coskun";
        kurs1.IzlenmeOrani = 75;



        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Barıs";
        kurs2.IzlenmeOrani = 85;



        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Nihal";
        kurs3.IzlenmeOrani = 65;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "C++";
        kurs4.Egitmen = "Büsra";
        kurs4.IzlenmeOrani = 65;


        // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen );
        }

        //Console.WriteLine("Hello, World!");
    }

    class Kurs
    {
        //proop yazarak kısayolla ekleyebiliyouz.
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }




}