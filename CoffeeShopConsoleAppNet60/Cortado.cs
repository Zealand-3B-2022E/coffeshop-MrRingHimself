using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public int mlMilk()
        {
           return 40;
        }

        public override string Price()
        {
            return "25 DKK";
        }

        public override string Strength()
        {
            return "Medium";
        }

        public Cortado()
        {

        }
        public override string ToString()
        {
            return $"Cortado is {Strength()} and costs {Price()} ";
        }
    }
}
