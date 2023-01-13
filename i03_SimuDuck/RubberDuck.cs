using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackbehavior = new Squeak();
        }
        public override void display()
        {
            Console.WriteLine("резинорва уточка");
        }
    }
}
