using SimUDuckApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckApp.Subtypes
{
    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("squak");
        }
    }
}
