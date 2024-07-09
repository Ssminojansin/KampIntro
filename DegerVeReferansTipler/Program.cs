internal class Program
{
    private static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        Console.WriteLine(sayi1);

        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };

        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        Console.WriteLine(sayilar1[0]);

        //int double decimal bool float = değer tipidir.
        //Array Class Interface = Referans tiplerdir.


        //Bellekte stack ve heap bölümleri vardır
        //Değerler stack de gerçekleşir.

        //Referans tipler ise heapte oluşur.. örneğin;
        //stack - 101 // sayilar1 ---------> heap - [10,20,30] vb.
        //stack - 102 // sayilar2 ---------> heap - [100,200,300] vb.
        //Değer tiplerde değer Referans tiplerde adres atanır.


    }
}