using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_EnumNedir
{
    public class sanalDatabase
    {
        ArrayList sanalIDB = new ArrayList();

        public musteriReturnValue musteriYeniKayit(Musteri m)
        {
            //Parametre kontrol

            //kayıt kontrol

            sanalIDB.Add(m);
            return musteriReturnValue.kayitBasarili;
        }
    }
}
