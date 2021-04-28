using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Helper
    {
        public static bool Control(string pin,string pan,string cvc)
        {
            if(pan.Length == 10&&pin.Length ==4&&cvc.Length ==3)
            {
                return true;
            }
            return false;

        }
    }
}
