using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class GrandChild : Child
    {
        //demonstrate overriding a base class method by a child
        public override void SomeMethod()
        {
            Console.WriteLine("GrandChild's SomeMethod");
        }

        //demonstrate a child method calling the parent's method
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("GrandChild.Method2");

        }

        public void SpecializedMethod()
        {
            Console.WriteLine("SpecializedMethod");
        }
    }
}
