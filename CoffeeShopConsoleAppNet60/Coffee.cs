using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {

        public virtual string Price()
        {
            return "20 DKK";
        }


        public abstract string Strength();
        
        
    }
}
