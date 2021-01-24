using System;
using System.Collections.Generic;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Ekle(1, "Osman Özkan");
            ogrenciler.Ekle(2, "Ahmet Özkan");

            //ogrenciler.Listele();

            ogrenciler.Ekle(3, "Furkan Özkan");
            ogrenciler.Ekle(4, "Emre Özkan");
            //ogrenciler.Listele();

            //ogrenciler.Ekle(1, "Yeni Öğrenci");
            //ogrenciler.Listele();

            ogrenciler.Listele(2);



        }

        
    }
}
