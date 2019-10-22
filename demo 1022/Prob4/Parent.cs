using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Parent
    {
        //show that a method belonging to the base class is called from the
        //child instance
        public void ParentMethod()
        {
            Console.WriteLine("Print out parent method");
        }

        //demonstrate overriding a base class method by a child
        public virtual void SomeMethod()
        {
            Console.WriteLine("Parent's SomeMethod");
        }

        //demonstrate a child method calling the parent's method
        public virtual void Method2()
        {
            Console.WriteLine("Parent.Method2");
        }
    }
}
