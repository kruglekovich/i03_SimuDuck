using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("я лечу на реактивной тяге");
        }
    }
}