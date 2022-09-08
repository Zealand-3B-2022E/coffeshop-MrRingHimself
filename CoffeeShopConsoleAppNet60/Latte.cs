using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public int mlMilk()
        {
            return 200;
        }

        public override string Price()
        {
            return "40 DKK";
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
