using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Ogrenci : BaseKisi
    {//Proerty tanımlaması yapılıyor.
        public int OgrenciNumarasi { get; set; }
    
        //Ogrencinin bilgilerini gösterecek metot tanımlanıyor.
    public void OgrenciGoster()
        {
            Console.WriteLine($" Ogrencinin Adı: {Ad}" +
                              $"\n Ogrencinin Soyadı: {Soyad}" +
                              $"\n Ogrenci Numarası: {OgrenciNumarasi}" +
                              $"\n -----------------------------------");
        }
    }
}
