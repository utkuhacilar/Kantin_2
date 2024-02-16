using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kantin_Uygulaması
{
    class Last5Order
    {
        private static Last5Order _instance;
        public static Last5Order Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Last5Order();
                return _instance;
            }
        }
    }
}
