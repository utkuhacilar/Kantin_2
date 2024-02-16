using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantin_Uygulaması
{
    class SecilenUrun
    {
        private static SecilenUrun _instance;
        public static  SecilenUrun Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SecilenUrun();
                return _instance;
            }
        }
        public bool karisik, kasarli, sandvic, doner, patso, pogaca, cay, su, kahve, ayran, makarna, corba;
        public int kactanekarisik = 0, kactanekasarli = 0, kactanesandvic = 0, kactanedoner = 0, kactanepatso = 0, kactanepogaca = 0, kactanecay = 0, kactanesu = 0, kactanekahve = 0, kactaneayran = 0, kactanemakarna = 0, kactanecorba = 0;
        public int fiyat = 0;
    }
}
