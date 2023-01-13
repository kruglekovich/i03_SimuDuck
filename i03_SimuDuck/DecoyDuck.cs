using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackbehavior = new MuteQuack();
        }
        public override void display()
        {
            Console.WriteLine("учтока приманка");
        }
    }
}