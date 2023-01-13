using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("уточка не говорит");
        }
    }
}
