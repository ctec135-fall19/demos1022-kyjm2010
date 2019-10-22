using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array of the base class type is created and initialized
            //with a member of each class in the hierarchy
            Parent[] myArray = new Parent[3];
            myArray[0] = new Parent();
            myArray[1] = new Child();
            myArray[2] = new GrandChild();


            //show that a method belonging to the base class is called from the 
            //child instance
            //create parentMethod() in parent and iterate through array
            //calling this method to demonstrate that all child classes
            //have access to it.
            foreach(Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.ParentMethod();

            }
            Console.WriteLine();
            #endregion

            #region demonstrate overriding a base class method by a child
            foreach (Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.SomeMethod();

            }
            Console.WriteLine();
            #endregion

            #region demonstrate a child method calling the parent's method
            //create a virtual method in parent 
            //override in child and call the parent as part of the 
            //implementation
            foreach (Parent element in myArray)
            {
                Console.Write("{0}: ", element.GetType());
                element.Method2();
                Console.WriteLine();

            }
            Console.WriteLine();
            #endregion

            #region Demonstrate use of "as" keyword
            //repeat calls to SomeMethod 
            foreach(object element in myArray)
            {
                Parent p = element as Parent;
                //Parent p = (Parent)element;
                Console.Write("{0}: ", p.GetType());
                p.SomeMethod();
            }
            Console.WriteLine();

            #endregion
            #region Demonstrate use of "is" keyword
            Console.WriteLine("Demo use of is");

            foreach(Parent element in myArray)
            {
                if (element is GrandChild) Console.WriteLine("GrandChhild");
                else if (element is Child) Console.WriteLine("Child");
                else if (element is Parent) Console.WriteLine("Parent");
            }
            Console.WriteLine();
            #endregion

            #region switch
            Console.WriteLine("Demo switch");
            foreach(Parent element in myArray)
            {
                switch (element)
                {
                    case GrandChild gc:
                        Console.WriteLine("GrandChild");
                        break;
                    case Child c:
                        Console.WriteLine("Child");
                        break;
                    case Parent p:
                        Console.WriteLine("Parent");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;

                }
            }
            Console.WriteLine();
            #endregion

            #region object of object type initialized to base class type 
            object obj = new Parent();
            ((Parent)obj).ParentMethod();

            Parent p2 = new GrandChild();
            ((GrandChild)p2).SpecializedMethod();
            #endregion
        }
    }
}
