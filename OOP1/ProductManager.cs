using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        // void methodları demek işlemleri emir kipi kullanır gibi örneğin git ekle git güncelle
        //detaylı bilgi vermeyen işlemin sonucuyla ilgili olmayan işlemler için kullanılır.

        //
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + "  Eklendi  ");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "  Güncellendi  ");
        }




        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
                
         }
        //void ile yapılan işlemlerde dönüş olmadığı için başka yerde başka bir işlemle (örneğin çarpma ) kullanılamaz.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); 

        }







        /* public void BiseyYap(int sayi)
         {
             sayi = 99;
         }*/

    }
}
