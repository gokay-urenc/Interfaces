using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Biyoloji_Ogretmeni : Ogretmen, ISertifika
    {
        public string sertifika_bilgisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}