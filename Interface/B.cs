using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class B : IA
    {
        public int ozellik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int okunabilir_ozellik => throw new NotImplementedException();

        public string Fonksiyon()
        {
            throw new NotImplementedException();
        }
    }
}