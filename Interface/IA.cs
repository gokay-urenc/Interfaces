using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IA
    {
        string Fonksiyon();
        int ozellik { get; set; }
        int okunabilir_ozellik { get; }
    }
}
/* C# dilinde 1 class sadece 1 class'tan miras alabilir.
   Interface'ler bu problemi gidermeye yarar.
   Interface ile amaçlanan çoklu miras(multiple interface)'dır.
   Interface sadece miras verir.
   Interfacelerden abstract classlar gibi instance alınamaz.
   Aslında her interface yarı abstract'tır.
   Interface oluşturmanın amacı temel özellikleri barındırmaktır.
   Bazı kullanım kısıtlamaları vardır.
   Kısıtlamalar:
   * Instance alınamaz.
   * Field tanımlanamaz.
   * Üyeleri sadece property ve methodlardır.
   * Üyelerinin erişim seviyeleri private olamaz ve erişim seviyesi tanımlanamaz. Genel olmalıdır.
   * Interface miras vereceği için üyeleri miras alan sınıf tarafından devralınması gereken yapılardır. Bu yüzden private yaparak interface içerisinde üye saklanamaz.
   * Üyelerinin gövdeleri olmaz.
   * Üyeleri abstract üyelerde olduğu gibi implement(tamamlanmak veya dahil edilmek) zorundadır.
   * Genellikle bir şart olmasa da yazısız bir kural olarak interface tanımlamalarında dosya adının başına "I" eklenmelidir.
*/