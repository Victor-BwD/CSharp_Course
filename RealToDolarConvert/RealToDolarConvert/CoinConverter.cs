using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarToRealConvert
{
    class CoinConverter
    {
        public static float IOF = 6.0f;

        public static float DolarToReal(float quantity, float price)
        {
            float total = quantity * price;
            return total + (total * IOF / 100);
        }
    }
}
