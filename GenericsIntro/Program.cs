using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> isimler = new MyList<string>();
        isimler.Add("Coskun");

        Console.WriteLine(isimler.Length);

        isimler.Add("Büsra");

        Console.WriteLine(isimler.Length);

        isimler.Add("Baris");

        Console.WriteLine(isimler.Length);

        isimler.Add("Nihal");

        Console.WriteLine(isimler.Length);



        foreach (var item in isimler.Items)
        {
            Console.WriteLine(item);
        }


        //List<string> liste = new List<string>();
        //Console.WriteLine(liste.Count);

    }
}