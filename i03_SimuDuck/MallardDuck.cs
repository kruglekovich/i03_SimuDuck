using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackbehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("Мандариновая уточка");
        }
    }
}
