using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    // Operasyon tutuyor demektir.
    internal class SepetManager
    {
        // Naming Convention 
        // bir method çalışıyor demek () böyle olunca.
        //Parantezin içine parametre yazarız...
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler - Sepete Eklendi!! : " + urun.Adi);
        }

        
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        
        {
            Console.WriteLine("Tebrikler - Sepete Eklendi!! : " + urunAdi);
        }
    }
}
