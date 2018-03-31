using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overriding_With_Abstract_Class
{
    abstract class Program  // abstract class
    {
        public abstract string GetString();  // abstract Method
        public abstract void Show();        // abstract Method
    }

    class NewProgram : Program   // Derived class
    {
        public override string GetString()   // Overriding method of abstract method
        {
            return "Derived Class GetString";  
        }

        public override void Show()   // Overriding method of abstract method
        {
            Console.WriteLine("Derived Class Show");
        }
    }
   
class main
   {
        static void Main(string[] args)
        {
            NewProgram obj = new NewProgram();  //Note: We can not create instance of the abstract class
            string str = obj.GetString();
            Console.WriteLine("Method Returns:{0}", str);
            obj.Show();
            Program obj1 = (Program)obj;  //cast the derived class object to base class type
            str = obj1.GetString();
            Console.WriteLine("Method Returns:{0}", str);
            obj1.Show();
            obj = (NewProgram)obj1;
            str = obj.GetString();
            Console.WriteLine("Method Returns:{0}", str);
            obj.Show();
            Console.Read();
        }
    }
}
