using OOP1;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Masa";
        product1.UnitPrice = 500;
        product1.UnitsInStock = 3;


        Product product2 = new Product {Id=2,CategoryId=5, ProductName="Kalem", UnitsInStock=5, UnitPrice=35 };

        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
        productManager.Update(product2);


        productManager.Topla2(3,6);

        int ToplamaSonucu = productManager.Topla(5, 6);
        Console.WriteLine(ToplamaSonucu*2);





        // Console.WriteLine(product1.ProductName);

        /* int sayi = 100;
         productManager.BiseyYap(sayi);
         Console.WriteLine(sayi);*/


        //int double float bool decimal = değer tipleridir. Atamalar tamamen değer üzerinden olur. Değer harici bütün bağlantılar kopar.
        //diziler classlar abstrat-classlar interface = Referans tiplerdir.
        //Classlar referans atamsı üzerinden yaplıyor.

    }
}