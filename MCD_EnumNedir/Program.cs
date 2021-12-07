using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_EnumNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.id = 1;
            M1.musteriNumara = "MSN001";
            M1.isim = "esra";
            M1.soyisim = "alkan";
            M1.emailAdres = "es.alknn@gmail.com";

            sanalDatabase SB = new sanalDatabase();
            musteriReturnValue musteriKayitSonuc = SB.musteriYeniKayit(M1);

            int enumInt = (int)musteriReturnValue.kayitBasarili;
            Console.WriteLine(enumInt);

            //if (musteriKayitSonuc == musteriReturnValue.kayitBasarili)
            //{

            //}
        }
    }
}
