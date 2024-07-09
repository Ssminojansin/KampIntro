using IkinciGunOdev6;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.ProductName = "Spor Ayakakkabısı";
        product1.ProductDescription = "Futbol Ayakkabısı";
        product1.ProductPrice = 100;

        Product product2 = new Product();
        product2.ProductName = "Spor Ayakakkabısı";
        product2.ProductDescription = "Basketbol Ayakkabısı";
        product2.ProductPrice = 200;

        Product product3 = new Product();
        product3.ProductName = "Spor Ayakakkabısı";
        product3.ProductDescription = "Tenis Ayakkabısı";
        product3.ProductPrice = 300;

        Product[] products = new Product[]  {product1,product2,product3 };

        foreach (Product product in products)
        {
            Console.WriteLine("Ürün Adı : " + product.ProductName);
            Console.WriteLine("Ürün Açıklaması : " + product.ProductDescription);
            Console.WriteLine("Ürün Fiyatı : " + product.ProductPrice);
        }

        Console.WriteLine("----------------------------------------------");


        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine("Ürün Adı : " + products[i].ProductName + "Ürün Açıklaması : " + products[i].ProductDescription + " Ürün Fiyatı : " + products[i].ProductPrice  );
        }

        Console.WriteLine("------------------------------------------------");

        int x = 0;
        while (x<products.Length)
        {
            
            Console.WriteLine("Ürün adı : " + products[x].ProductName + "Ürün Açıklaması : " + products[x].ProductDescription + "Ürün Fiyatı : " + products[x].ProductPrice);
            x++;
        }
        

    }
}