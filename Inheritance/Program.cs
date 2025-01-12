
//Nesneler oluşturuluyor.
using Inheritance;

Ogrenci ogrenci = new Ogrenci();

Ogretmen ogretmen = new Ogretmen();

//Ogrenci ve Ogretmen için değişkenlerimiz dolduruluyor.

ogrenci.Ad = "Ayşe";
ogrenci.Soyad = "Öztürk";
ogrenci.OgrenciNumarasi = 1507;

ogretmen.Ad = "Ahmet";
ogretmen.Soyad = "Eroglu";
ogretmen.Maas = 40000;

//Ogrenci ve Ogretmen bilgilerini görmek için metodu çağırıyoruz.

ogrenci.Person();

ogretmen.Person();