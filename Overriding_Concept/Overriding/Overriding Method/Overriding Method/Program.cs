using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overriding_Method
{
    class Program
    {
        public virtual void display()
        {
            Console.WriteLine("Base Class Display Method Called");
        }

    }
        class PrgramNew:Program
        {
            public override void display()
            {
                Console.WriteLine("Derived Class Display Method Called");
            }
        }

        abstract class Base  // its another class abstract class
        {
            public abstract void Show();
        }
        class derived : Base   // inherit the derived class by abstract class
        {
            public override void Show()   //It is mandatory to implement absract method
            {
                Console.WriteLine("Abstract method in derived");
            }
        }

    class demo
    {
        static void Main(string[] args)
        {
             
            Program obj;
            obj = new Program();
            obj.display();       
            PrgramNew obj1;
            obj1 = new PrgramNew(); 
            obj1.display();        
            obj = new PrgramNew(); 
            obj.display();
            obj = (Program)obj1;
            obj.display();
            obj1 = (PrgramNew)obj;
            obj1.display();
            // abstract class method called here now //
            derived new_derived;
            new_derived = new derived();
            new_derived.Show();
            Console.ReadKey();
        }
    }
}
