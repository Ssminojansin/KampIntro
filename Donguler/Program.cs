internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "yazılım geliştirme kampı";
        string kurs2 = "Programlamaya başlangıç için tmel kurs";
        string kurs3 = "Java";
        //Dizilerde tanımlama yaparsak bir sürü değişken tutabiliriz. (Array)

        string[] kurslar = new string[] { "yazılım geliştirme kampı", "Programlamaya başlangıç için temel kurs" ,"Java","Python" };
        

        for (int i = 0; i < kurslar.Length; i++) // yada i+=2 aynı şeydir.
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("------------------For bitti.------------------");

        //Foreach dizi temelli yapıları tek tek dönmeye yarar. Forecah dizilere uygulanır.
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("Sayfa Sonu");
    }





}