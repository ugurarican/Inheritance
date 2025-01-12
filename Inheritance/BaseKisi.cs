using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Tek başına kullanılmasına izin vermemek için soyutluyoruz.
    public abstract class BaseKisi
    {
        // Propertyler tanımlanıyor.
        public string Ad { get; set; }
        public string Soyad { get; set; }
    // virtual keyword ile tanımlanan metot override edilebilir oluyor ve bu classı implemente eden class bu metodu kendi isteğine göre düzenleyebiliyor.
    public virtual void Person()
        {
            Console.WriteLine($"{Ad} {Soyad}");
        }
    }
}
