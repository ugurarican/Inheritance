using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        //Ogretmenin bilgilerini tanımlayacak metot tanımlanıyor.
    public void OgretmenGoster()
        {
            Console.WriteLine($" Ogretmenin Adı: {Ad}" +
                              $"\n Ogretmenin Soyadı: {Soyad}" +
                              $"\n Ogretmenin Maası: {Maas}" +
                              $"\n -----------------------------------");
        }
    }
}
