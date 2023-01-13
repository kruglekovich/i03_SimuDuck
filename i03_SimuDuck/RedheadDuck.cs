using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackbehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("красноголовая уточка");
        }
    }
}
