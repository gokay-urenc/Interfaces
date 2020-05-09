using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Ogrenci : Insan
    {
        Ogrenci ogr = new Ogrenci();
        public Ogrenci()
        {
            ogr.ad_soyad = "Negan Lucille";
        }
    }
}
// Class seviyesi değişken tanımlama bu şekildedir.
// Class seviyesi değişkene class seviyesinden erişilemez. Methodlardan erişilir.
// int a;
// button1_Click()
// {
//     a = 5;   => Aynı mantık.
// }