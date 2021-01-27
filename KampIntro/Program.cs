using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemGirisYapmısMı = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            
            
            if (sistemGirisYapmısMı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
